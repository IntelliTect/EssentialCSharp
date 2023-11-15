namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_22;

public class TimeOnlyHelper
{
    #region INCLUDE
    public static TimeOnly GetTime(object input) =>
        input switch
        {
            DateTime datetime
                => TimeOnly.FromDateTime(datetime),
            DateTimeOffset datetimeOffset
                    => TimeOnly.FromDateTime(datetimeOffset.DateTime),
            string dateText => TimeOnly.Parse(
                dateText),
            null => throw new ArgumentNullException(nameof(input)),
            _ => throw new ArgumentException(
                $"Invalid type - {input.GetType().FullName}"),
        };
    #endregion INCLUDE
}
