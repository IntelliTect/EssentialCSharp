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
            < 6 => "黎明",
            < 12 => "上午",
            < 18 => "下午",
            < 24 => "晚上",
            int hour => throw new ArgumentOutOfRangeException(nameof(hourOfTheDay),
                $"指定了一天中无效的小时数。")
        };
    #endregion INCLUDE
}
