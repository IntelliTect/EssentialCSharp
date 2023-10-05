namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_42;

#region INCLUDE
interface IReadOnlyPair<T>
{
    T First { get; }
    T Second { get; }
}

interface IPair<T>
{
    T First { get; set; }
    T Second { get; set; }
}

public struct Pair<T> : IPair<T>, IReadOnlyPair<T>
{
    #region EXCLUDE
    #region Generated Interface Stub
    public T First
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }

    public T Second
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }
    #endregion Generated Interface Stub
    #endregion EXCLUDE
}

public class Program
{
    static void Main()
    {
        // Only possible with out type parameter
        #region HIGHLIGHT
        //Pair<Contact> contacts =
        //    new Pair<Contact>(
        //        new Contact("Princess Buttercup"),
        //        new Contact("Inigo Montoya"));
        //IReadOnlyPair<PdaItem> pair = contacts;
        //PdaItem pdaItem1 = pair.First;
        //PdaItem pdaItem2 = pair.Second;
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
