namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_23;

#region INCLUDE
using System.Diagnostics.CodeAnalysis;

public static class SolsticeHelper
{
    public static bool IsSolstice(
        DateTime date)
    {
        if (date.Day is 21)
        {
            if (date.Month is 12)
            {
                return true;
            }
            if (date.Month is 6)
            {
                return true;
            }
        }
        return false;
    }

    public static bool TryGetSolstice(DateTime date,
        [NotNullWhen(true)] out string? solstice
    )
    {
        if (date.Day is 21)
        {
            if ((solstice = date.Month switch
            {
                12 => "Winter Solstice",
                6 => "Summer Solstice",
                _ => null
            }) is not null) return true;
        }
        solstice = null;
        return false;
    }
}
#endregion INCLUDE
