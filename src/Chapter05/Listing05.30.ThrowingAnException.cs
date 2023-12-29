#pragma warning disable CS1058
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0162 // Unreachable code detected
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_30;

public class ThrowingExceptions
{
    // ��һ��catch�Ӿ��Ѳ��������쳣
    #region INCLUDE
    public static void Main()
    {
        try
        {
            Console.WriteLine("��ʼִ��");
            Console.WriteLine("�׳��쳣");
            #region HIGHLIGHT
            throw new Exception("�����쳣");
            // Catch 1
            #endregion HIGHLIGHT
            Console.WriteLine("����ִ��");
        }
        catch(FormatException exception)
        {
            Console.WriteLine(
                "���׳�һ��FormatException�쳣");
        }
        // Catch 1
        catch(Exception exception)
        {
            Console.WriteLine(
                $"��Ԥ�ڵĴ���: { exception.Message }");
            // ��ת��Post Catch
        }

        // Post Catch
        Console.WriteLine(
            "���ڹر�...");
    }
    #endregion INCLUDE
}
