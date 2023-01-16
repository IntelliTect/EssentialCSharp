namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_18;

#pragma warning disable 0693 // Disabled warning due to nested type parameter
// with overlapping name
#region INCLUDE
public class Container<T, U>
{
    // Nested classes inherit type parameter
    // Reusing a type parameter name will cause
    // a warning
    public class Nested<U>
    {
        #region HIGHLIGHT
        static void Method(T param0, U param1)
        #endregion HIGHLIGHT
        {
        }
    }
}
#endregion INCLUDE
