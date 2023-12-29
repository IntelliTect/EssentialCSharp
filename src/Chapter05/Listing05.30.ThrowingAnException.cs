#pragma warning disable CS1058
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0162 // Unreachable code detected
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_30;

public class ThrowingExceptions
{
    // 上一个catch子句已捕获所有异常
    #region INCLUDE
    public static void Main()
    {
        try
        {
            Console.WriteLine("开始执行");
            Console.WriteLine("抛出异常");
            #region HIGHLIGHT
            throw new Exception("任意异常");
            // Catch 1
            #endregion HIGHLIGHT
            Console.WriteLine("结束执行");
        }
        catch(FormatException exception)
        {
            Console.WriteLine(
                "已抛出一个FormatException异常");
        }
        // Catch 1
        catch(Exception exception)
        {
            Console.WriteLine(
                $"非预期的错误: { exception.Message }");
            // 跳转到Post Catch
        }

        // Post Catch
        Console.WriteLine(
            "正在关闭...");
    }
    #endregion INCLUDE
}
