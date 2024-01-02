// Variable is declared but never used
#pragma warning disable CS0168

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_29;

using Listing06_28;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Employee employee;

#if COMPILEERROR // EXCLUDE
        #region HIGHLIGHT
        // 错误：没有获取0个参数的Employee方法重载        
        employee = new Employee();
        #endregion HIGHLIGHT
#endif // COMPILEERROR // EXCLUDE

        // ...
    }
}
#endregion INCLUDE
