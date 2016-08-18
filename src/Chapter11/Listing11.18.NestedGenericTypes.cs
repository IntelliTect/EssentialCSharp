namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_18
{
    class Container<T, U>
    {
        // Nested classes inherit type parameters.
        // Reusing a type parameter name will cause
        // a warning.
        class Nested<U>
        {
            void Method(T param0, U param1)
            {
            }
        }
    }
}