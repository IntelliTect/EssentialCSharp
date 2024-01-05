using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_25;

public class PeriodsOfTheDay
{
    #region INCLUDE
    public static bool IsStandardWorkHours(
        TimeOnly time) =>
            time.Hour is > 8
                and < 17
                and not 12; // ���ʱ�䲻�Ǳ�׼����ʱ��

    public static bool TryGetPhoneButton(
        char character,
        [NotNullWhen(true)] out char? button)
    {
        return (button = char.ToLower(character) switch
        {
            '1' => '1',
            '2' or >= 'a' and <= 'c' => '2',
            // not��������Բ����ʾ��(C# 10)
            '3' or not (< 'd' or > 'f') => '3',
            '4' or >= 'g' and <= 'i' => '4',
            '5' or >= 'j' and <= 'l' => '5',
            '6' or >= 'm' and <= 'o' => '6',
            '7' or >= 'p' and <= 's' => '7',
            '8' or >= 't' and <= 'v' => '8',
            '9' or >= 'w' and <= 'z' => '9',
            '0' or '+' => '0',
            _ => null,// ����button��ָʾֵ����Ч��
        }) is not null;
    }
    #endregion INCLUDE
}
