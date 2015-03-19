using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WINHelper
{
    public static class WIN32
    {
        public  const int GWL_ID = (-12);
        public  const int GWL_STYLE = (-16);
        public   const int GWL_EXSTYLE = (-20);

        public  const uint WM_SETTEXT = 0x000C;
        public  const int WM_COMMAND = 0x0111;
        public  const int BN_CLICKED = 0;


        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
     
       /*GetNextWindow function :Retrieves a handle to the next or previous window in the Z-Order. The next window is below the specified window; the previous window is above.
HWND WINAPI GetNextWindow(
 _In_  HWND hWnd, //A handle to a window. The window handle retrieved is relative to this window, based on the value of the wCmd parameter. 
 _In_  UINT wCmd //Indicates whether the function returns a handle to the next window or the previous window. This parameter can be either of the following values
);

Value           Meaning 
GW_HWNDNEXT
2               Returns a handle to the window below the given window.
GW_HWNDPREV
3               Returns a handle to the window above the given window.
 
        但是真正差API的时候，说是没有这个函数，这既是个宏，建议用GetWindow
        */

        public enum WindowLoc
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }

        /*Retrieves a handle to a window that has the specified relationship (Z-Order or owner) to the specified window. 
        hWnd : A handle to a window. The window handle retrieved is relative to this window, based on the value of the uCmd parameter. 
        uCmd:The relationship between the specified window and the window whose handle is to be retrieved
         */


        [DllImport("user32.dll", SetLastError = true)]
       public static extern IntPtr GetWindow(IntPtr hWnd, WindowLoc uCmd);

        //这里也模拟一个GetNextWindow
        public enum NextWindow
        {
            PREV,
            NEXT
        }
        public static IntPtr GetNextWindow(IntPtr hWnd, NextWindow next) {
            if(next == NextWindow.NEXT)
            {
                return GetWindow(hWnd,WindowLoc.GW_HWNDNEXT);
            }else if(next == NextWindow.PREV)
            {
                return GetWindow(hWnd, WindowLoc.GW_HWNDPREV);
            }else
            {
                return IntPtr.Zero;
            }
        }
    
       // Find window by Caption only. Note you must pass IntPtr.Zero as the first parameter.

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        // You can also call FindWindow(default(string), lpWindowName) or FindWindow((string)null, lpWindowName)

        public delegate bool Win32Callback(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32.Dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr parentHandle, Win32Callback callback, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam,
            string lParam);

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam,
        //    IntPtr lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageForButton(IntPtr hWnd, uint Msg, IntPtr wParam,
            IntPtr lParam);


        /*BN_CLICKED is a notification message sent by the button to the parent window. 
        *Assuming this is what you want to do, you can try:  
         HWND hwndParent = GetParentHwnd();   replace this with the parent window handle
         HWND hwndButton = GetButtonHwnd();   replace this with the button handle
         UINT nButtonID = GetButtonID();      replace this with the button ID       
         ::SendMessage(hwndParent, WM_COMMAND, MAKELONG(nButtonID, BN_CLICKED), hwndButton); or
         ::PostMessage(hwndParent, WM_COMMAND, MAKELONG(nButtonID, BN_CLICKED), hwndButton);  
         or, if you have a CWnd pointer to the parent window and the button ID:  
         CWnd* pParentWnd = GetParentWnd();  // replace this with the parent window 
         UINT nButtonID = GetButtonID();     // replace this with the button ID 
         CWnd* pButtonWnd = pParentWnd->GetDlgItem(nButtonID); 
         pParentWnd->SendMessage(WM_COMMAND, MAKELONG(nButtonID, BN_CLICKED), pButtonWnd->GetSafeHwnd()); or
         pParentWnd->PostMessage(WM_COMMAND, MAKELONG(nButtonID, BN_CLICKED), pButtonWnd->GetSafeHwnd());
         
         The MAKELONG macro creates an unsigned 32-bit value by concatenating two given 16-bit values. 
         DWORD MAKELONG( WORD wLow,  // low-order word of long value  
         *               WORD wHigh  // high-order word of long value  );
          
         The MAKELONG macro is defined as follows:
            #define MAKELONG(a, b) \
            ((LONG) (((WORD) (a)) | ((DWORD) ((WORD) (b))) << 16))
         */
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern IntPtr SendButtonClick(IntPtr hParent, uint Msg, IntPtr wParam,
            IntPtr hButton);

        public static void SendButtonClick(IntPtr hParent, IntPtr hButton)
        {
            int controlID = GetWindowLong(hButton, GWL_ID);

            IntPtr wParam = (IntPtr)((BN_CLICKED << 16) | (controlID & 0xffff));

            WIN32.SendMessageForButton(hParent, WM_COMMAND, wParam, hButton);      
        }

    }
}
