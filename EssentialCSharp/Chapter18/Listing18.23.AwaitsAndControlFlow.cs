namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.Listing18_23
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using System.Threading.Tasks;
    using System.Net.NetworkInformation;
    using System.Collections.Generic;

    public class Program : Form
    {
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Label StatusLabel;

        [STAThread]
        public static void Main()
        {
            Application.Run(new Program());
        }

        public Program()
        {
            InitializeComponent();
        }

        async private void PingButton_Click(object sender, EventArgs e)
        {
            List<string> urls = new List<string>()
            {
                "www.habitat-spokane.org",
                "www.partnersintl.org",
                "www.iassist.org",
                "www.fh.org",
                "www.worldvision.org"
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

            StatusLabel.Text = "Pinging…";

            foreach(string url in urls)
            {
                status = await func(url);
                StatusLabel.Text =
                    string.Format("{0}: {1} ({2})",
                    url, status.ToString(),
                    Thread.CurrentThread.ManagedThreadId);
            }
        }

        private void InitializeComponent()
        {
            this.PingButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PingButton
            // 
            this.PingButton.Location = new System.Drawing.Point(12, 119);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(75, 23);
            this.PingButton.TabIndex = 0;
            this.PingButton.Text = "Ping";
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 17);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(66, 13);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Status Label";
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(260, 154);
            this.Controls.Add(this.PingButton);
            this.Controls.Add(this.StatusLabel);
            this.Name = "Program";
            this.Text = "Multithreading in Windows Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}