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
        // 必须在对象初始化值设定项或属性构造函数中
        // 设置所需的成员'Book.Isbn'。                
#if COMPILEERROR // EXCLUDE
        Book book = new() { Title= "Essential C#" };
#endif // COMPILEERROR // EXCLUDE

        // ...
        #endregion INCLUDE
    }
}
#endif // NET7_0_OR_GREATER // EXCLUDE
