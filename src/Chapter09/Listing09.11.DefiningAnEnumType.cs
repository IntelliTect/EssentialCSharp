namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_11
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
