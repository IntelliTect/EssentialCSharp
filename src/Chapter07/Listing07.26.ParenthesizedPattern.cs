using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_26;

public class PeriodsOfTheDay
{
    #region INCLUDE
    public bool IsOutsideOfStandardWorkHours(
        TimeOnly time) =>
            time.Hour is not
                (> 8 and < 17 and not 12); // Parenthesis Pattern - C# 10.
    #endregion INCLUDE

    public static bool TryGetPhoneButton(
        char character,
        [NotNullWhen(true)] out char? button)
    {
        return (button = char.ToLower(character) switch
        {
            '1' => '1',
            '2' or >= 'a' and <= 'c' => '2',
            // not operator and parenthesis example (C# 10)
            '3' or not (< 'd' or > 'f') => '3',
            '4' or >= 'g' and <= 'i' => '4',
            '5' or >= 'j' and <= 'l' => '5',
            '6' or >= 'm' and <= 'o' => '6',
            '7' or >= 'p' and <= 's' => '7',
            '8' or >= 't' and <= 'v' => '8',
            '9' or >= 'w' and <= 'z' => '9',
            '0' or '+' => '0',
            _ => null,// Set the button to indicate an invalid value
        }) is not null;
    }
}
