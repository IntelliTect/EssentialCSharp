namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_13
{
    public class Controller
    {
        public void Start()
        {
            // Critical code
        }

        public void Run()
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
