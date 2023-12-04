namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_21;

public class TimeOnlyHelper
{
    #region INCLUDE
    public static TimeOnly GetTime(object input)
    {
        switch (input)
        {
            case DateTime datetime:
                return TimeOnly.FromDateTime(datetime);
            case DateTimeOffset datetimeOffset:
                return TimeOnly.FromDateTime(datetimeOffset.DateTime);
            case string dateText:
                return TimeOnly.Parse(dateText);
            case null:
               throw new ArgumentNullException(nameof(input));
            default:
                throw new ArgumentException(
                    $"Invalid type - {input.GetType().FullName}");
        };
    }
    #endregion INCLUDE
}
