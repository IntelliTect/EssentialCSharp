namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_50;

#region INCLUDE
public class Employee
{
    // ...
    #region HIGHLIGHT
    public static int NextId
    {
        get
        {
            return _NextId;
        }
        private set
        {
            _NextId = value;
        }
    }
    public static int _NextId = 42;
    #endregion HIGHLIGHT
    // ...
}
#endregion INCLUDE
