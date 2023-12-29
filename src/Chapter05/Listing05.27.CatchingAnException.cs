namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_27;

#region INCLUDE
public class ExceptionHandling
{
    public static int Main(string[] args)
    {
        string? firstName;
        string ageText;
        int age;
        int result = 0;

        Console.WriteLine("�٣��㣡");

        Console.Write("�������������: ");
        firstName = Console.ReadLine();        
        Console.Write("�������������: ");
        // ���費Ϊ��
        ageText = Console.ReadLine()!;

        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
                $"��ã�{firstName}������{age * 12}���´��ˡ�");
        }
        catch(FormatException)
        {
            Console.WriteLine(
                $"�����������'{ ageText }'����һ����Ч��������"); 
            result = 1;
        }
        catch(Exception exception)
        {
            Console.WriteLine(
                $"��Ԥ�ڵĴ���: { exception.Message }");
            result = 1;
        }
        finally
        {
            Console.WriteLine($"�ټ���{ firstName }��");
        }

        return result;
    }
}
#endregion INCLUDE
