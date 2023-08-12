namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_29;

using System.Collections.Generic;
using System;

#region INCLUDE
public class EntityBase<TKey>
{
    #region HIGHLIGHT
    public EntityBase(TKey key)
    {
        Key = key;
    }
    #endregion HIGHLIGHT
    public TKey Key { get; set; }
}

public class EntityDictionary<TKey, TValue, TFactory> :
  Dictionary<TKey, TValue>
    where TKey : IComparable<TKey>, IFormattable
    #region HIGHLIGHT
    where TValue : EntityBase<TKey>
    where TFactory : IEntityFactory<TKey, TValue>, new()
    #endregion HIGHLIGHT
{
    // ...

    public TValue New(TKey key)
    {
        TFactory factory = new();
        #region HIGHLIGHT
        TValue newEntity = factory.CreateNew(key);
        #endregion HIGHLIGHT
        Add(newEntity.Key, newEntity);
        return newEntity;
    }
    //...
}

#region HIGHLIGHT
public interface IEntityFactory<TKey, TValue>
{
    TValue CreateNew(TKey key);
}
#endregion HIGHLIGHT
#endregion INCLUDE
