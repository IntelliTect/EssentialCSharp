namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02;

public class Program
{
    #region INCLUDE
    #nullable enable
    public static void Main()
    {
        // 因为演示的是编译错误，所以在项目编译时排除。
        // 要想体验这个错误，注释掉#if和#endif这两行即可。
        // 体验完毕后，记得恢复。
        #if COMPILEERROR // EXCLUDE
        string? text;
        // ...
        // 编译错误：使用了未赋值的局部变量'text'
        System.Console.WriteLine(text.Length);
        #endif // COMPILEERROR // EXCLUDE
    }
    #endregion INCLUDE
}
