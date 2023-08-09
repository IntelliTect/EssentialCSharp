namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_37;

using System;
#region INCLUDE
[Flags]
enum DistributedChannel
{
    None = 0,
    Transacted = 1,
    Queued = 2,
    Encrypted = 4,
    Persisted = 16,
    #region HIGHLIGHT
    FaultTolerant =
        Transacted | Queued | Persisted
    #endregion HIGHLIGHT
}
#endregion INCLUDE
