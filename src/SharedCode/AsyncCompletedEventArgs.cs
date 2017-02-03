using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public class AsyncCompletedEventArgs : EventArgs
    {
        public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState) { }
        public bool Cancelled { get; }
        public Exception Error { get; }
        public object UserState { get; }
        protected void RaiseExceptionIfNecessary() { throw new NotImplementedException(); }
    }
}
