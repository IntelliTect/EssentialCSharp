namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_23;

#region INCLUDE
public class EntityDictionary<TKey, TValue>
    : System.Collections.Generic.Dictionary<TKey, TValue>
    #region HIGHLIGHT
    where TKey : notnull
    where TValue : EntityBase
    #endregion HIGHLIGHT
{
    // ...
}
#endregion INCLUDE
public class EntityBase
{
}
