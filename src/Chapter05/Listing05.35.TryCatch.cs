namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_35;

public class LeveragingTryParse
{
    public static void Main()
    {
        string? firstName;
        string ageText;

        Console.Write("�������������: ");
        firstName = Console.ReadLine();

        Console.Write("�������������: "); 
        // Assume not null for clarity
        ageText = Console.ReadLine()!;
        #region INCLUDE
        if (int.TryParse(ageText, out int age))
        {
            Console.WriteLine(
                $"��ã�{ firstName }��" +
                $"����{age * 12}���´��ˡ�");
        }
        else
        {
            Console.WriteLine(
                $"�����������'{ageText}'����һ����Ч��������");
        }
        #endregion INCLUDE
    }
}
