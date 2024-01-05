namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24;

public class PeriodsOfTheDay
{
    #region INCLUDE
    public static bool IsDeveloperWorkHours(
        int hourOfTheDay) =>
            hourOfTheDay is > 10 &&
                hourOfTheDay is < 24;


    public static string GetPeriodOfDay(int hourOfTheDay) =>
        hourOfTheDay switch
        {
            < 6 => "����",
            < 12 => "����",
            < 18 => "����",
            < 24 => "����",
            int hour => throw new ArgumentOutOfRangeException(nameof(hourOfTheDay),
                $"ָ����һ������Ч��Сʱ����")
        };
    #endregion INCLUDE
}
