using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Reflection;
using System.Runtime.InteropServices;
using System;
using System.Windows.Media;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            //this.wbBaidu.ScriptErrorsSuppressed = false;

            this.wbBaidu.Navigate("http://www.baidu.com");
            this.wbAli.Navigate("http://www.alibaba.com");
            //this.wbGoogle.Navigate("http://Google.com");

            Uri uri_google = new Uri(string.Format("http://stackoverflow.com/questions/6138199/wpf-webbrowser-control-how-to-supress-script-errors"));
            this.wbGoogle.Navigate(uri_google);
        }

        public void Go()
        {
            Initialize();
        }


        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            Go();
        }

        private void WebBrowserNavigated(object sender, NavigationEventArgs e)
        {
            WebBrowser wb = sender as WebBrowser;
            SetSilent(wb, true);
            System.Diagnostics.Trace.TraceInformation("navigated" + wb.Name);
        }

        public void SetSilent(WebBrowser browser, bool silent)
        {
            if (browser == null)
                throw new ArgumentNullException("browser");

            // get an IWebBrowser2 from the document
            IOleServiceProvider sp = browser.Document as IOleServiceProvider;
            if (sp != null)
            {
                Guid IID_IWebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");
                Guid IID_IWebBrowser2 = new Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E");

                object webBrowser;
                sp.QueryService(ref IID_IWebBrowserApp, ref IID_IWebBrowser2, out webBrowser);
                if (webBrowser != null)
                {
                    webBrowser.GetType().InvokeMember("Silent", BindingFlags.Instance | BindingFlags.Public | BindingFlags.PutDispProperty, null, webBrowser, new object[] { silent });
                }
            }
        }

        private void WebBrowserLoadCompleted(object sender, NavigationEventArgs e)
        {
            //WebBrowser wb = sender as WebBrowser;
            //if(wb == null)
            //{
            //    throw new ArgumentNullException("No Browser passed in in WebBrowserLoadCompleted");
            //}

            //TabItem tab = GetTabItemByBrowser(wb);
            //tab.Background = Brushes.Green;
        }

        private TabItem GetTabItemByBrowser(WebBrowser wb)
        {
            if (wb.Name == UtilConst.BROWSER_NAME_BAIDU)
            {
                return this.tabBaidu;
            }else if (wb.Name == "wbAli")
            {
                return this.tabAli;
            }
            else if (wb.Name == "wbGoogle")
            {
                return this.tabGoogle;
            }else
            {
                throw new NotSupportedException("Not supported browser in GetTabItemByBrowser");
            }

        }
    }
} 


[ComImport, Guid("6D5140C1-7436-11CE-8034-00AA006009FA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
interface IOleServiceProvider {[PreserveSig]   int QueryService([In] ref Guid guidService, [In] ref Guid riid, [MarshalAs(UnmanagedType.IDispatch)] out object ppvObject); }