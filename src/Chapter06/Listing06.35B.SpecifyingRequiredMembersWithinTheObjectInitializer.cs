#if NET7_0_OR_GREATER

#if COMPILEERROR
using AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35A;
#endif // COMPILEERROR

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35B
{
    public class Program
    {
        public static void Main()
        {
            #if COMPILEERROR
            #region INCLUDE
            // Error CS9035:
            // Required member 'Book.Isbn' must be set in the object
            // initializer or attribute constructor
            Book book = 
                new() { Title= "Essential C#" };

            // ...
            #endregion INCLUDE
            #endif // COMPILEERROR
          }
    }
}
#endif // NET7_0_OR_GREATER