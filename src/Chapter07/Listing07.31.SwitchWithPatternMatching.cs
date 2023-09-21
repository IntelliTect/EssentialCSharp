namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_31;

public class Program
{
    #region INCLUDE
    public static string? CompositeFormatDate(
            object input, string compositeFormatString) =>
        input switch
        {
            DateTime 
                { Year: int year, Month: int month, Day: int day }
                => (year, month, day),
            DateTimeOffset
                { Year: int year, Month: int month, Day: int day }
                    => (year, month, day),
            DateOnly 
                { Year: int year, Month: int month, Day: int day }
                    => (year, month, day),
            string dateText => DateTime.TryParse(
                dateText, out DateTime dateTime) ?
                    (dateTime.Year, dateTime.Month, dateTime.Day) :
                    // default ((int Year, int Month, int Day)?)
                    // preferable but not covered until Chapter 12.
                    ((int Year, int Month, int Day)?) null,
            _ => null
        } is (int, int, int) date ? string.Format(
            compositeFormatString, date.Year, date.Month, date.Day) : null;
    #endregion INCLUDE
}
file static class DateDeconstructors
{
    public static void Deconstruct(this DateTime date, out int year, out int month, out int day) => (year, month, day) = (date.Year, date.Month, date.Day);
}

