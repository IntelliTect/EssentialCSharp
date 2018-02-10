namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_13
{
    public class Controller
    {
        public void Start()
        {
            // Critical code
        }

        private void Run()
        {
            Start();
            InternalRun();
            Stop();
        }

        protected virtual void InternalRun()
        {
            // Default implementation
        }

        public void Stop()
        {
            // Critical code
        }
    }
}
