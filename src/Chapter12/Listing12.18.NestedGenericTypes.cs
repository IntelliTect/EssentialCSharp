namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_18
{
    #pragma warning disable 0693 // Disabled warning due to nested type parameter
                                 // with overlapping name
    class Container<T, U>
    {
        // Nested classes inherit type parameter
        // Reusing a type parameter name will cause
        // a warning
        class Nested<U>
        {
            void Method(T param0, U param1)
            {
            }
        }
    }
}
