using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using Windows.Storage;
using Microsoft.Web.WebView2.Core;
using System.Reflection.Metadata.Ecma335;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow 
    {
        Uri myUri = new Uri("https://www.google.com", UriKind.Absolute);
        public MainWindow()
        {
        
            InitializeComponent();
            InitializeAsync();
        }
        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                if (addressBar.Text.Substring(0, 8) == "https://" || addressBar.Text.Substring(0, 7) == "http://")
                {
                    webView.CoreWebView2.Navigate(addressBar.Text);
                }
                else webView.CoreWebView2.Navigate("https://"+addressBar.Text);

            }
        }
        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            addressBar.Text = uri;
           // webView.CoreWebView2.PostWebMessageAsString(uri);
        }
        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }
        private void tbCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            tbControl = (sender as TabControl);
            testname = (sender as TabItem);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           /* TabItem newTabItem = new TabItem
            {
                Header = "Test",
                Name = "Test"
                 
            };
            tbControl.Items.Add(newTabItem);*/
             WebView2 webBrowser3 = new WebView2
            {
               
                Source = myUri,
                
            };
            tbControl.Items.Add(webBrowser3);

        }
    }
}
