namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_13;

#region INCLUDE
enum ConnectionState : short
{
    Disconnected,
    Connecting = 10,
    Connected,
    Joined = Connected,
    Disconnecting
}
#endregion INCLUDE
