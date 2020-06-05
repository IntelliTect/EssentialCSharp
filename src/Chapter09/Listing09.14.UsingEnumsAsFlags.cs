namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_14
{
    using System;

    [Flags]
    public enum FileAttributes
    {
        None = 0,                       // 000000000000000
        ReadOnly = 1 << 0,              // 000000000000001
        Hidden = 1 << 1,                // 000000000000010
        System = 1 << 2,                // 000000000000100
        Directory = 1 << 4,             // 000000000010000
        Archive = 1 << 5,               // 000000000100000
        Device = 1 << 6,                // 000000001000000
        Normal = 1 << 7,                // 000000010000000
        Temporary = 1 << 8,             // 000000100000000
        SparseFile = 1 << 9,            // 000001000000000
        ReparsePoint = 1 << 10,         // 000010000000000
        Compressed = 1 << 11,           // 000100000000000
        Offline = 1 << 12,              // 001000000000000
        NotContentIndexed = 1 << 13,    // 010000000000000
        Encrypted = 1 << 14,            // 100000000000000
    }
}
