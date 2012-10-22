namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.Listing18_21
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using System.Threading.Tasks;
    using System.Net.NetworkInformation;

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

        private void PingButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Pinging…";
            Ping ping = new Ping();
            PingReply pingReply =
                ping.Send("www.IntelliTect.com");
            StatusLabel.Text = pingReply.Status.ToString();
        }

        private void InitializeComponent()
        {
            this.PingButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PingButton
            // 
            this.PingButton.Location = new System.Drawing.Point(13, 47);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(75, 23);
            this.PingButton.TabIndex = 0;
            this.PingButton.Text = "Ping";
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(13, 17);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(100, 23);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Status Label";
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(260, 90);
            this.Controls.Add(this.PingButton);
            this.Controls.Add(this.StatusLabel);
            this.Name = "Program";
            this.Text = "Multithreading in Windows Forms";
            this.ResumeLayout(false);

        }
    }
}