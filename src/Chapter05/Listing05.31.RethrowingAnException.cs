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
            Console.WriteLine("��ʼִ��");
            Console.WriteLine("�׳��쳣");
            throw new Exception("�����쳣");
            Console.WriteLine("����ִ��");
        }
        catch (FormatException exception)
        {
            Console.WriteLine(
                "�׳���һ��FormatException�쳣");
        }
        #region INCLUDE
        // ...
        catch (Exception exception)
        {
            Console.WriteLine(
                "�����׳���Ԥ�ڵ��쳣:  "
                + $"{ exception.Message }");

            throw;
        }
        // ...
        #endregion INCLUDE
        catch
        {
            Console.WriteLine("��Ԥ�ڵĴ���!");
        }

        Console.WriteLine(
            "���ڹر�...");
    }
}
