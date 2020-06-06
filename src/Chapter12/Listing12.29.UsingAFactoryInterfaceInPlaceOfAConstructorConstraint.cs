namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_29
{
    using System.Collections.Generic;
    using System;

    public class EntityBase<TKey>
    {
        public EntityBase(TKey key)
        {
            Key = key;
        }
        public TKey Key { get; set; }
    }

    public interface IEntityFactory<TKey, TValue>
    {
        TValue CreateNew(TKey key);
    }

    public class EntityDictionary<TKey, TValue, TFactory> :
      Dictionary<TKey, TValue>
        where TKey : IComparable<TKey>, IFormattable
        where TValue : EntityBase<TKey>
        where TFactory : IEntityFactory<TKey, TValue>, new()
    {
        // ...

        public TValue New(TKey key)
        {
            TFactory factory = new TFactory();
            TValue newEntity = factory.CreateNew(key);
            Add(newEntity.Key, newEntity);
            return newEntity;
        }
        //...
    }
}
