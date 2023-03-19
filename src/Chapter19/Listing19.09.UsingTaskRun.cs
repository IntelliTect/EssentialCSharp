namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_09;

using System.Threading.Tasks;

public class Program
{
    #region INCLUDE
    public static Task<string> CalculatePiAsync(int digits)
    {
        return Task.Factory.StartNew<string>(
            () => Program.CalculatePi(digits));
    }

    private static string CalculatePi(int digits)
    {
        #region EXCLUDE
        return string.Empty;
        #endregion EXCLUDEe
    }
    #endregion INCLUDE
}

