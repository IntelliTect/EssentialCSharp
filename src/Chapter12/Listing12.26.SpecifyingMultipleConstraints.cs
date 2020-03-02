namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_25
{
    using System;
    using System.Collections.Generic;
    using Listing12_23;

    public class EntityDictionary<TKey, TValue>
        : Dictionary<TKey, TValue>
        where TKey : IComparable<TKey>, IFormattable
        where TValue : EntityBase
    {
        // ...
    }
}
