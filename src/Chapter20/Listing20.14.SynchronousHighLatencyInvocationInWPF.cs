namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_14
{
    public class Program
    {
        private void PingButton_Click(
           object sender, RoutedEventArgs e)
        {
            StatusLabel.Content = "Pinging...";
            UpdateLayout();
            Ping ping = new Ping();
            PingReply pingReply =
                ping.Send("www.IntelliTect.com");
            StatusLabel.Text = pingReply.Status.ToString();
        }
    }
}





