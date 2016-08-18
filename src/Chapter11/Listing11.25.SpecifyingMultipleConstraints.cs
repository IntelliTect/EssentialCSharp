namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_25
{
    using System;
    using System.Collections.Generic;
    using Listing11_23;

    public class EntityDictionary<TKey, TValue>
        : Dictionary<TKey, TValue>
        where TKey : IComparable<TKey>, IFormattable
        where TValue : EntityBase
    {
        // ...
    }
}