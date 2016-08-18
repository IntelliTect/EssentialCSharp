namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.Listing18_22
{
    using System;
    using System.Windows;
    using System.Net.NetworkInformation;

    public class Program : Window
    {
        private System.Windows.Controls.StackPanel StackPanel;
        private System.Windows.Controls.Button PingButton;
        private System.Windows.Controls.TextBlock StatusLabel;

        [STAThread]
        public static void Main()
        {
            var app = new Application();
            app.Run(new Program());
        }


        public Program()
        {
            InitializeComponent();
        }

        async private void PingButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Pinging…";
            Ping ping = new Ping();
            PingReply pingReply =
                await ping.SendPingAsync("yahoo.com");
            StatusLabel.Text = pingReply.Status.ToString();
        }

        private void InitializeComponent()
        {
            StackPanel = new System.Windows.Controls.StackPanel
            {
                Margin = new Thickness(13)
            };
            PingButton = new System.Windows.Controls.Button
            {
                Content = "Ping",
                HorizontalAlignment = HorizontalAlignment.Left
            };
            StatusLabel = new System.Windows.Controls.TextBlock
            {
                Text = "Ready",
                Margin = new Thickness(0, 0, 0, 10)
            };

            Content = StackPanel;

            StackPanel.Children.Add(StatusLabel);
            StackPanel.Children.Add(PingButton);

            PingButton.Click += PingButton_Click;

            MinWidth = 260;
            MinHeight = 100;
            SizeToContent = SizeToContent.WidthAndHeight;
            Title = "Multithreading in WPF";

        }
    }
}