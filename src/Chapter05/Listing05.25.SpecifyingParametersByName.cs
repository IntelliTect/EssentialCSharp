namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_25;

public class SpecifyingParametersByName
{
    #region INCLUDE
    public static void Main()
    {
        #region HIGHLIGHT
        DisplayGreeting(
            firstName: "Inigo", lastName: "Montoya");
        #endregion HIGHLIGHT
    }

    public static void DisplayGreeting(
        string firstName,
        string? middleName = null,
        string? lastName = null
        )
    {
        #region EXCLUDE
        string fullName = $"名字: {firstName} 中间名: {middleName} 姓氏: {lastName}";
        Console.Write(fullName);
        #endregion EXCLUDE
    }
    #endregion INCLUDE
}
