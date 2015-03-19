using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace EnumOwnChildWindow
{
    public partial class Form1 : Form
    {
        public delegate bool Win32Callback(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32.Dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr parentHandle, Win32Callback callback, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam,
            string lParam);

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam,
        //    IntPtr lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        static extern IntPtr SendMessageForButton(IntPtr hWnd, uint Msg, IntPtr wParam,
            IntPtr lParam);

        const int GWL_ID = (-12);
        const int GWL_STYLE = (-16);
        const int GWL_EXSTYLE = (-20);

        const uint WM_SETTEXT = 0x000C;
        const int WM_COMMAND = 0x0111;
        const int BN_CLICKED = 0;

        public Form1()
        {
            InitializeComponent();
        }

        int set = 0;

        private void btnSum_Click(object sender, EventArgs e)
        {
            this.txbResult.Text = (int.Parse(this.txbNumber1.Text) + int.Parse(this.txbNumber2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListChildWindow(this.Handle);
        }


        public void ListChildWindow(IntPtr pHWND){
            if(pHWND == IntPtr.Zero)
            {
                pHWND = Process.GetCurrentProcess().MainWindowHandle;
            }

            EnumChildWindows(pHWND, ChildProc, IntPtr.Zero);

        }


        public bool ChildProc(IntPtr hwnd, IntPtr lParam)
        {
            this.rtbChildList.AppendText(string.Format("HWnd:{0}, Hex:0x{1}\r\n",(int)hwnd,Convert.ToString((int)hwnd,16)));

            int nResult = 0;
            // Pre-allocate 256 characters, since this is the maximum class name length.
            StringBuilder sbClassName = new StringBuilder(256);
            //Get the window class name
            nResult = GetClassName(hwnd, sbClassName, sbClassName.Capacity);
            if(nResult != 0)
            {
                this.rtbChildList.AppendText(string.Format("\tClasName:{0}\r\n",sbClassName.ToString()));
            }

            //so ID equals Hwnd. we could not get the name property, it's special for C#, windows API does not know this property.
            this.rtbChildList.AppendText(string.Format("\tID:{0}\r\n", GetWindowLong(hwnd, GWL_ID)));

            if(sbClassName.ToString().ToLower().Contains("edit"))
            {
                if (set == 0)
                {
                    set++;
                    return true;
                }
               // SendMessage(hwnd, WM_SETTEXT, IntPtr.Zero, "12345");

                //Random r = new Random();


                //IntPtr text = Marshal.StringToCoTaskMemUni(r.Next(1,1000).ToString());
                //SendMessage(hwnd, WM_SETTEXT, IntPtr.Zero, text); 
                //Marshal.FreeCoTaskMem(text);
               // set++;
            }

           IntPtr wParam = (IntPtr) ((BN_CLICKED << 16) | (((int)hwnd) & 0xffff));
            if(sbClassName.ToString().ToLower().Contains("button"))
            {
                SendMessageForButton(hwnd, WM_COMMAND, wParam, hwnd);
            }
            return true;
        }


        //public IntPtr FindWindow(IntPtr parentHandle, Predicate<IntPtr> target)
        //{
        //    var result = IntPtr.Zero;
        //    if (parentHandle == IntPtr.Zero)
        //        parentHandle = Process.GetCurrentProcess().MainWindowHandle;

        //    EnumChildWindows(parentHandle, (hwnd, param) =>
        //    {
              
        //        return true;
        //    }, IntPtr.Zero);
        //    return result;
        //}


    }
}
