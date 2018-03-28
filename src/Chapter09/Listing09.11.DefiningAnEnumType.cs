namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_11
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
