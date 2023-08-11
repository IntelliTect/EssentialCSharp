namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_40;

#region INCLUDE
using System.Diagnostics.CodeAnalysis;
#region EXCLUDE
public class NullabilityAttributesExamined
{
#endregion EXCLUDE
    static public bool TryGetDigitAsText(
        char number, [NotNullWhen(true)]out string? text) =>
            (text = number switch
            {
                '1' => "one",
                '2' => "two",
                '3' => "three",
                '4' => "four",
                // ...
                '9' => "nine",
                _ => null
            }) is not null;

#if NET7_0_OR_GREATER // EXCLUDE
    // nameof() on parameters is not supported prior to C# 11/.NET 7.0
    [return: NotNullIfNotNull(nameof(text))]
#else // EXCLUDE
    [return: NotNullIfNotNull("text")] // EXCLUDE
#endif // EXCLUDE
    static public string? TryGetDigitsAsText(string? text)
    {
        if (text == null) return null;

        string result = "";
        foreach (char character in text)
        {
            if (TryGetDigitAsText(character, out string? digitText))
            {
                if (result != "") result += '-';
                result += digitText.ToLower();
            }
        }
        return result;
    }
#endregion INCLUDE
}
