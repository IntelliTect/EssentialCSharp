namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_26;

using System;
using System.Collections.Generic;
#region INCLUDE
public class EntityBase<TKey>
    where TKey: notnull
{
    public EntityBase(TKey key)
    {
        Key = key;
    }
    
    public TKey Key { get; set; }
}

public class EntityDictionary<TKey, TValue> :
    Dictionary<TKey, TValue>
    where TKey : IComparable<TKey>, IFormattable
    #region HIGHLIGHT
    where TValue : EntityBase<TKey>, new()
    #endregion HIGHLIGHT
{
    public TValue MakeValue(TKey key)
    {
        #region HIGHLIGHT
        TValue newEntity = new()
        {
        #endregion HIGHLIGHT
            Key = key
        };
        Add(newEntity.Key, newEntity);
        return newEntity;
    }

    // ...
}
#endregion INCLUDE
