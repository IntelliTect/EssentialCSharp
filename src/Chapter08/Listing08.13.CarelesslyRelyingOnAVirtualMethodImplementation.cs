namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_13
{
    public class WorkflowActivity
    {
        private static void Start()
        {
            // Critical code
        }
        public virtual void Run()
        {
            WorkflowActivity.Start();
            // Do something...
            WorkflowActivity.Stop();
        }
        private static void Stop()
        {
            // Critical code
        }
    }
}
