#pragma warning disable CS0162 // Unreachable code detected
#pragma warning disable CS1058 // A previous catch clause already catches all exceptions
#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_31;

public class ThrowingExceptions
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("开始执行");
            Console.WriteLine("抛出异常");
            throw new Exception("任意异常");
            Console.WriteLine("结束执行");
        }
        catch (FormatException exception)
        {
            Console.WriteLine(
                "抛出了一个FormatException异常");
        }
        #region INCLUDE
        // ...
        catch (Exception exception)
        {
            Console.WriteLine(
                "重新抛出非预期的异常:  "
                + $"{ exception.Message }");

            throw;
        }
        // ...
        #endregion INCLUDE
        catch
        {
            Console.WriteLine("非预期的错误!");
        }

        Console.WriteLine(
            "正在关闭...");
    }
}
