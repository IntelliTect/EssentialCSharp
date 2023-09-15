namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_54;

#region INCLUDE
public class Employee
{
    public Employee(int id)
    {
      _Id = id;
    }

    // ...

    #region HIGHLIGHT
    private readonly int _Id;
    #endregion HIGHLIGHT
    public int Id
    {
      get { return _Id; }
    }

    #if COMPILEERROR // EXCLUDE
    // Error: A readonly field cannot be assigned to (except
    // in a constructor or a variable initializer)
    public void SetId(int id) =>
        _Id = id;
    #endif // COMPILEERROR // EXCLUDE

    // ...
}
#endregion INCLUDE
