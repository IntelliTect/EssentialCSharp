//namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.ListingC_11
//{
//    using System;
//    using System.Drawing;
//    using System.Threading;
//    using System.Threading.Tasks;
//    using System.Windows.Forms;

//    public class Program : Form
//    {
//        private System.Windows.Forms.ProgressBar _ProgressBar;

//        [STAThread]
//        public static void ChapterMain()
//        {
//            Application.Run(new Program());
//        }

//        public Program()
//        {
//            InitializeComponent();
//            // Prior to TPL use:
//            //     ThreadPool.QueueUserWorkItem(state=>Increment());
//            // Use Task.Factory.StartNew for .NET 4.0
//            Task task = Task.Run((Action)Increment);
//        }

//        void UpdateProgressBar()
//        {
//            if(_ProgressBar.InvokeRequired)
//            {
//                MethodInvoker updateProgressBar =
//                    UpdateProgressBar;
//                _ProgressBar.BeginInvoke(updateProgressBar);
//            }
//            else
//            {
//                _ProgressBar.Increment(1);
//            }
//        }

//        private void Increment()
//        {
//            for(int i = 0; i < 100; i++)
//            {
//                UpdateProgressBar();
//                Thread.Sleep(100);
//            }

//            if(InvokeRequired)
//            {
//                // Close cannot be called directly from 
//                // a non-UI thread.
//                Invoke(new MethodInvoker(Close));
//            }
//            else
//            {
//                Close();
//            }
//        }

//        private void InitializeComponent()
//        {
//            _ProgressBar = new ProgressBar();
//            SuspendLayout();

//            _ProgressBar.Location = new Point(13, 17);
//            _ProgressBar.Size = new Size(267, 19);

//            ClientSize = new Size(292, 53);
//            Controls.Add(this._ProgressBar);
//            Text = "Multithreading in Windows Forms";
//            ResumeLayout(false);
//        }
//    }
//}