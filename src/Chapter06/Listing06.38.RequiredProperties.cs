namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_38;

#if NET7_0_OR_GREATER
#region INCLUDE
public class Book
{
    public Book()
  {
      // Look up employee name...
      // ...
  }

    string? _Title;
    #region HIGHLIGHT
    public required string Title
    #endregion HIGHLIGHT
    {
        get
        {
            return _Title!;
        }
        set
        {
            _Title = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    string? _Isbn;
    #region HIGHLIGHT
    public required string Isbn
    #endregion HIGHLIGHT
    {
        get
        {
            return _Isbn!;
        }
        set
        {
            _Isbn = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public string? Subtitle { get; set; }

    // ...
}

public class Program
{
    public static void Main()
    {
        #region EXCLUDE
        #pragma warning disable IDE0059 // Unnecessary assignment of a value
        #endregion EXCLUDE
        Book book = new()
        {
            Isbn = "978-0135972267",
            Title = "Harold and the Purple Crayon"
        };
        #region EXCLUDE
        #pragma warning restore IDE0059 // Unnecessary assignment of a value
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
#endif // NET7_0_OR_GREATER