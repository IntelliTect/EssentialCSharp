namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_01;

#region INCLUDE
public class Stack
{
    public virtual object Pop()
    {
        #region EXCLUDE
        return new object();
        #endregion EXCLUDE
    }

    public virtual void Push(object obj)
    {
        // ...
    }
    // ...
}
#endregion INCLUDE
