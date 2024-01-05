namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_01;

using System;
using System.Diagnostics.CodeAnalysis;

#region INCLUDE
public class PdaItem
{
    [DisallowNull]
    public string? Name { get; set; }
    public DateTime LastUpdated { get; set; }
}
// Contact类从PdaItem类继承
#region HIGHLIGHT
public class Contact : PdaItem
#endregion HIGHLIGHT
{
    public string? Address { get; set; }
    public string? Phone { get; set; }

    // ...
}
#endregion INCLUDE
