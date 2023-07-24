namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_32;

using System;
#region INCLUDE
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
public class Program
{
    public static void Main()
    {
        ConnectionState1[] states =
        #region HIGHLIGHT
            (ConnectionState1[])(Array)new ConnectionState2[42];
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
