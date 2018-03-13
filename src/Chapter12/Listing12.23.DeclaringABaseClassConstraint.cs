namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_23
{
    public class EntityDictionary<TKey, TValue>
        : System.Collections.Generic.Dictionary<TKey, TValue>
        where TValue : EntityBase
    {
        //...
    }

    public class EntityBase
    {
    }
}