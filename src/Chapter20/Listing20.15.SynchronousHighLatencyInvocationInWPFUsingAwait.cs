namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_15
{
    public class Program
    {
        async private void PingButton_Click(
    object sender, RoutedEventArgs e)
        {
            StatusLabel.Content = "Pinging...";
            UpdateLayout();
            Ping ping = new Ping();
            PingReply pingReply =
                await ping.SendPingAsync("www.IntelliTect.com");
            StatusLabel.Text = pingReply.Status.ToString();
        }

    }
}





