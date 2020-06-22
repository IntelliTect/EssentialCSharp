namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_10
{
    enum ConnectionState : short
    {
        Disconnected,
        Connecting = 10,
        Connected,
        Joined = Connected,
        Disconnecting
    }
}
