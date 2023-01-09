namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_19A;

public class TimeOnlyHelper
{
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
                throw new Exception();
            default:
                throw new ArgumentException(
                    $"Invalid type - {input.GetType().FullName}");
        };
    }
}

