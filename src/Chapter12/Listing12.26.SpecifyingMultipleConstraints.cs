namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_25
{
    using Listing12_23;
    using System;
    using System.Collections.Generic;
    #region INCLUDE
    public class EntityDictionary<TKey, TValue>
        : Dictionary<TKey, TValue>
        where TKey : IComparable<TKey>, IFormattable
        where TValue : EntityBase
    {
        // ...
    }
    #endregion INCLUDE
}
