#if NET7_0_OR_GREATER

#if COMPILEERROR // EXCLUDE
using AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_37;
#endif // COMPILEERROR // EXCLUDE

using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_38;

public class Program
{
    public static void Main()
    {
        #if COMPILEERROR // EXCLUDE
        #region INCLUDE
        // Error CS9035:
        // Required member 'Book.Isbn' must be set in the object
        // initializer or attribute constructor
        Book book = new() { Title= "Essential C#" };

        // ...
        #endregion INCLUDE
        #endif // COMPILEERROR // EXCLUDE
      }
}
#endif // NET7_0_OR_GREATER
