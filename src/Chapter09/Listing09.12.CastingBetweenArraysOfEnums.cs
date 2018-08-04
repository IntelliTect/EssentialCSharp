namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_12
{
    using System;
    using Listing09_11;

    public class Program
    {
        public static void Main()
        {
            ConnectionState1[] states =
                (ConnectionState1[])(Array)new ConnectionState2[42];
        }
    }

    enum ConnectionState1
    {
        Disconnected,
        Connecting,
        Connected,
        Disconnecting
    }

    enum ConnectionState2
    {
        Disconnected,
        Connecting,
        Connected,
        Disconnecting
    }
}
