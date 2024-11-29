namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_15
{
    public class Program
    {
        #region INCLUDE
        #region HIGHLIGHT
        private async void PingButton_Click(
        #endregion HIGHLIGHT
    object sender, RoutedEventArgs e)
        {
            StatusLabel.Content = "Pinging...";
            UpdateLayout();
            Ping ping = new Ping();
            PingReply pingReply =
            #region HIGHLIGHT
                await ping.SendPingAsync("www.IntelliTect.com");
            #endregion HIGHLIGHT
            StatusLabel.Text = pingReply.Status.ToString();
        }
        #endregion INCLUDE
    }
}
