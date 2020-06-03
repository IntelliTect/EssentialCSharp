
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_36
{
    using System.Diagnostics.CodeAnalysis;

    public class NullabilityAttributesExamined
    {
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
                }) is string;

        [return: NotNullIfNotNull("text")]
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
    }
}
