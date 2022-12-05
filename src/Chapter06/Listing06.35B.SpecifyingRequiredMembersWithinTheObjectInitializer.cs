#if NET7_0_OR_GREATER

 #if INCLUDE
using AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35A;
 #endif // INCLUDE

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35B
{
    public class Program
    {
        public static void Main()
        {
            #if INCLUDE
            #region INCLUDE
            // Error CS9035:
            // Required member 'Book.Isbn' must be set in the object
            // initializer or attribute constructor
            Book book = 
                new() { Title= "Essential C#" };

            // ...
            #endregion INCLUDE
            #endif // INCLUDE
          }
    }
}
#endif // NET7_0_OR_GREATER