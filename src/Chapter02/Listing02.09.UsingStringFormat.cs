namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_09;

using System.Globalization;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // ...
        const double number = 86540910.21;
        string currencyText;

        currencyText = $"{number}";
        Console.WriteLine(currencyText);

        currencyText = $"{number:C}";
        Console.WriteLine(currencyText);

        // Prove that string interpolation and the ToString method produce equivalent results with format specifiers
        string toStringCurrencyText = number.ToString("C");
        Console.WriteLine($"{currencyText == toStringCurrencyText}: {currencyText} == {toStringCurrencyText}");

        // el-GR represents the Greek locale code
        toStringCurrencyText = number.ToString("C", CultureInfo.GetCultureInfo("el-GR"));
        Console.WriteLine(toStringCurrencyText);

        // ...
        #endregion INCLUDE
    }
}