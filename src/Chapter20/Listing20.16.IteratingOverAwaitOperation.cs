namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_16
{
    using System;
    using System.Collections.Generic;
    using System.Net.NetworkInformation;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        #region INCLUDE
        private async void PingButton_Click(
        object sender, RoutedEventArgs e)
        {
            List<string> urls = new List<string>()
                {
                    "www.habitat-spokane.org",
                    "www.partnersintl.org",
                    "www.iassist.org",
                    "www.fh.org",
                    "www.worldVision.org"
                };
            IPStatus status;

            Func<string, Task<IPStatus>> func =
                async (localUrl) =>
                {
                    Ping ping = new Ping();
                    PingReply pingReply =
                        await ping.SendPingAsync(localUrl);
                    return pingReply.Status;
                };

            StatusLabel.Content = "Pinging...";

            #region HIGHLIGHT
            foreach (string url in urls)
            {
                status = await func(url);
                StatusLabel.Text =
                    $@"{ url }: { status.ToString() } ({
                        Thread.CurrentThread.ManagedThreadId })";
            }
            #endregion HIGHLIGHT
        }
        #endregion INCLUDE
    }
}





