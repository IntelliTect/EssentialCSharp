namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_26
{
    using System;
    using System.Collections.Generic;

    public class EntityBase<TKey>
        where TKey: notnull
    {
        public TKey Key { get; set; }

        public EntityBase(TKey key)
        {
            Key = key;
        }
    }

    public class EntityDictionary<TKey, TValue> :
        Dictionary<TKey, TValue>
        where TKey : IComparable<TKey>, IFormattable
        where TValue : EntityBase<TKey>, new()
    {
        // ...

        public TValue MakeValue(TKey key)
        {
            TValue newEntity = new TValue
            {
                Key = key
            };
            Add(newEntity.Key, newEntity);
            return newEntity;
        }

        // ...
    }
}
