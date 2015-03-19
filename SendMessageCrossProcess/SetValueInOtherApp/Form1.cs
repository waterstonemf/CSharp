using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINHelper;

namespace SetValueInCPPApp
{
    public partial class FormSetValueInCPP : Form
    {

        private IntPtr _hWnd = IntPtr.Zero;
        private IntPtr _hWndMain = IntPtr.Zero;
        public FormSetValueInCPP()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            IntPtr hControl = FindControlByID(MainWindowResouce.ID_NUMBER2);

            if (hControl == IntPtr.Zero)
            {
                MessageBox.Show("No Control");
            }
            else
            {
                WIN32.SendMessage(hControl, WIN32.WM_SETTEXT, IntPtr.Zero, this.txbValue.Text);
            }

            IntPtr hbtnAdd = FindControlByID(MainWindowResouce.ID_BTNADD);

            if (hbtnAdd == IntPtr.Zero)
            {
                MessageBox.Show("No Control");
            }
            else
            {
                IntPtr wParam = (IntPtr)((WIN32.BN_CLICKED << 16) | (MainWindowResouce.ID_BTNADD & 0xffff));

                WIN32.SendMessageForButton(this._hWndMain, WIN32.WM_COMMAND, wParam, hbtnAdd);
            }
        }

        private void btnRaiseClick_Click(object sender, EventArgs e)
        {
            IntPtr hbtnAdd = FindControlByID(MainWindowResouce.ID_BTNADD);

            if (hbtnAdd == IntPtr.Zero)
            {
                MessageBox.Show("No Control");
            }
            else
            {
                WIN32.SendButtonClick(this._hWndMain, hbtnAdd);
            }
        }

        private bool ListControlPoc(IntPtr hwnd, IntPtr lParam)
        {
            this.rtbControls.AppendText(string.Format("HWnd:{0}, Hex:0x{1}\r\n", (int)hwnd, Convert.ToString((int)hwnd, 16)));

            int nResult = 0;
            // Pre-allocate 256 characters, since this is the maximum class name length.
            StringBuilder sbClassName = new StringBuilder(256);
            //Get the window class name
            nResult = WIN32.GetClassName(hwnd, sbClassName, sbClassName.Capacity);
            if (nResult != 0)
            {
                this.rtbControls.AppendText(string.Format("\tClasName:{0}\r\n", sbClassName.ToString()));
            }

            //so ID equals Hwnd. we could not get the name property, it's special for C#, windows API does not know this property.
            this.rtbControls.AppendText(string.Format("\tID:{0}\r\n", WIN32.GetWindowLong(hwnd, WIN32.GWL_ID)));

            if (sbClassName.ToString().ToLower().Contains("edit"))
            {
               
                // SendMessage(hwnd, WM_SETTEXT, IntPtr.Zero, "12345");

                //Random r = new Random();


                //IntPtr text = Marshal.StringToCoTaskMemUni(r.Next(1,1000).ToString());
                //SendMessage(hwnd, WM_SETTEXT, IntPtr.Zero, text); 
                //Marshal.FreeCoTaskMem(text);
                // set++;
            }

            IntPtr wParam = (IntPtr)((WIN32.BN_CLICKED << 16) | (((int)hwnd) & 0xffff));
            if (sbClassName.ToString().ToLower().Contains("button"))
            {
                WIN32.SendMessageForButton(hwnd, WIN32.WM_COMMAND, wParam, hwnd);
            }
            return true;
        }

        private IntPtr FindControlByID(int controlID)
        {
            if(this._hWndMain == IntPtr.Zero)
            {
                MessageBox.Show("No Main Window Captured!");
                return IntPtr.Zero;
            }

            this._hWnd = IntPtr.Zero;
            WIN32.EnumChildWindows(this._hWndMain, FindControl, (IntPtr)controlID);
           
            return this._hWnd;
        }

        //when return true, will continue to iterate next control
        //when return false, will abort the iteration
        private bool FindControl(IntPtr hwnd, IntPtr lParam)
        {
            int controlID = WIN32.GetWindowLong(hwnd, WIN32.GWL_ID);
            if (controlID == lParam.ToInt32())
            {
                this._hWnd = hwnd;
                return false;
            }
            return true;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            this.rtbControls.Clear();

            _hWndMain = WIN32.FindWindowByCaption(IntPtr.Zero, this.txbCaption.Text);

            if (_hWndMain != IntPtr.Zero)
            {
                WIN32.EnumChildWindows(_hWndMain, ListControlPoc, IntPtr.Zero);
            }
            else
            {
                this.rtbControls.AppendText("No Controls Captured");
            }
           }



        private void btnSetInCSharp_Click(object sender, EventArgs e)
        {
            IntPtr hlblNumber1 = WIN32.FindWindowEx(this._hWndMain, IntPtr.Zero, null, "Number1");
            IntPtr htxbNumber1 = WIN32.GetNextWindow(hlblNumber1, WIN32.NextWindow.NEXT);
            WIN32.SendMessage(htxbNumber1, WIN32.WM_SETTEXT, IntPtr.Zero, this.txbValue.Text);      
        }

        private void btnRaiseBtnClickInCSharp_Click(object sender, EventArgs e)
        {
            IntPtr hbtnAdd = WIN32.FindWindowEx(this._hWndMain, IntPtr.Zero, null, "Sum");

            if (hbtnAdd == IntPtr.Zero)
            {
                MessageBox.Show("No Control");
            }
            else
            {
                WIN32.SendButtonClick(this._hWndMain, hbtnAdd);
            }
        }
    }

    static class MainWindowResouce
    {
        public const int ID_NUMBER2 = 1004;
        public const int ID_BTNADD = 1000;
    }
}
