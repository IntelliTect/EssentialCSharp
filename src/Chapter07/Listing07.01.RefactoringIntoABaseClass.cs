// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Disabled pending base class invocation

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_01
{
    using System;

    public class PdaItem
    {
        public string Name { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    // Define the Contact class as inheriting the PdaItem class
    public class Contact : PdaItem
    {
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
