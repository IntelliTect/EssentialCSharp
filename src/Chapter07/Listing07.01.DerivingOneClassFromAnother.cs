namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_01
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public class PdaItem
    {
        [DisallowNull]
        public string? Name { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    // Define the Contact class as inheriting the PdaItem class
    public class Contact : PdaItem
    {
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
