using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24
{
    public class Program
    {
        public static string? CompositeFormatDate(
                object input, string compositFormatString) =>
            input switch
            {
                DateTime { Year: int year, Month: int month, Day: int day } tempDate
                    when tempDate < DateTime.Now
                    => (year, month, day),
                DateTimeOffset
                { Year: int year, Month: int month, Day: int day }
                        => (year, month, day),
                string dateText => DateTime.TryParse(
                    dateText, out DateTime dateTime) ?
                        (dateTime.Year, dateTime.Month, dateTime.Day) :
                        // default ((int Year, int Month, int Day)?) preferable
                        // not covered until Chapter 12.
                        ((int Year, int Month, int Day)?)null,
                _ => null
            } is { } date ? string.Format(
                compositFormatString, date.Year, date.Month, date.Day) : null;
    }
}
