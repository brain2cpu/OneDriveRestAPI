using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace OneDriveRestAPI
{
    public sealed partial class Login : IDisposable
    {
        private readonly Regex regex = new Regex("code=(.+)&lc=");
        private IAsyncOperation<ContentDialogResult> asyncDialog;

        public string Code { get; private set; } = "";
        public string ErrorMessage { get; private set; } = "";
        public bool? IsSuccess { get; private set; } = null;

        public Login()
        {
            InitializeComponent();
        }

        private static ManualResetEvent manualResetEvent = new ManualResetEvent(false);

        public async Task Navigate(string url)
        {
            manualResetEvent.Reset();

            Browser.Navigate(new Uri(url));
            asyncDialog = ShowAsync();

            await Task.Run(() => manualResetEvent.WaitOne());
        }

        private void Browser_OnNavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            if(!args.Uri.OriginalString.StartsWith(RequestGenerator.EndUrl))
                return;

            IsSuccess = args.IsSuccess;

            if(args.IsSuccess)
            {
                Match m = regex.Match(args.Uri.OriginalString);
                if(m.Success)
                    Code = m.Groups[1].Value;
                else
                    ErrorMessage = "Can not extract token";
            }
            else
                ErrorMessage = args.WebErrorStatus.ToString();

            asyncDialog.Cancel();

            manualResetEvent.Set();
        }

        public void Dispose()
        {
            if(manualResetEvent != null)
            {
                manualResetEvent.Dispose();
                manualResetEvent = null;
            }
        }
    }
}
