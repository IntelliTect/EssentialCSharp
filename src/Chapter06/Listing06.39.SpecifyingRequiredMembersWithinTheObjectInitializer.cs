#if NET7_0_OR_GREATER // EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_39;

using System.Runtime.CompilerServices;
using Listing06_38;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // Error CS9035:
        // Required member 'Book.Isbn' must be set in the object
        // initializer or attribute constructor
        #if COMPILEERROR // EXCLUDE
        Book book = new() { Title= "Essential C#" };
        #endif // COMPILEERROR // EXCLUDE

        // ...
        #endregion INCLUDE
    }
}
#endif // NET7_0_OR_GREATER // EXCLUDE
