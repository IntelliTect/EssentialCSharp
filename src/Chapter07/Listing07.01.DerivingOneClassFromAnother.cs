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
// Define the Contact class as inheriting the PdaItem class
#region HIGHLIGHT
public class Contact : PdaItem
#endregion HIGHLIGHT
{
    public string? Address { get; set; }
    public string? Phone { get; set; }

    // ...
}
#endregion INCLUDE
