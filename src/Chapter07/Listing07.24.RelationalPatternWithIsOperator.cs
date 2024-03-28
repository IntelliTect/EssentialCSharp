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
            < 6 => "Dawn",
            < 12 => "Morning",
            < 18 => "Afternoon",
            < 24 => "Evening",
            int hour => throw new ArgumentOutOfRangeException(nameof(hourOfTheDay), 
                $"The hour of the day specified ({hour}) is invalid.")
        };
    #endregion INCLUDE
}
