namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_13
{
    public class WorkflowActivity
    {
        private void Start()
        {
            // Critical code
        }
        public virtual void Run()
        {
            Start();
            // Do something...
            Stop();
        }
        private void Stop()
        {
            // Critical code
        }
    }
}
