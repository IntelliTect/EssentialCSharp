namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_26;

public class ExceptionHandling
{
    #region INCLUDE
    public static void Main()
    {
        string? firstName;
        string ageText;
        int age;

        Console.WriteLine("�٣��㣡");

        Console.Write("�������������: ");
        firstName = Console.ReadLine();

        #region HIGHLIGHT
        Console.Write("�������������: ");
        // ���費Ϊ��
        ageText = Console.ReadLine()!;
        age = int.Parse(ageText);

        Console.WriteLine(
            $"��ã�{ firstName }������{ age * 12 }���´��ˡ�");
        #endregion HIGHLIGHT
    }
    #endregion INCLUDE
}
