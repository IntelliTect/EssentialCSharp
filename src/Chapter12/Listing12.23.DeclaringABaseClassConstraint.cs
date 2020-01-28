namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_23
{
    public class EntityDictionary<TKey, TValue>
        : System.Collections.Generic.Dictionary<TKey, TValue>
        where TKey: notnull
        where TValue : EntityBase
    {
        //...
    }

    public class EntityBase
    {
    }
}
