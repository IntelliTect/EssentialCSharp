#if NET7_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_34A
{
    public class Program
    {
        public static void Main()
        {
            Book book1 = 
                new() { Isbn= "Essential C#",Title= "978-0135972267" };
            book1 =
                 new() { Isbn= "Essential C#", Title= "978-0135972267" };
            //book1 =
            //    new(42);
        }
    }

    /* 
    GUIDELINES
    DO NOT use constructor parameters to initialize required properties, instead rely on initializer specified values.
    DO NOT use SetRequiredParameters unless all required parameters are assigned valid values during construction (the nullability warnings will help identify the required non-nullable reference type properties.
    Not Proposed: "DO NOT use SetRequiredMembers unless there is a valid value you can assign to all required properties during construction."
    Not Proposed: CONSIDER required properties with a default constructor to force the use of an initializer rather than a constructor for all required properties.
    */

    #region INCLUDE
    public class Book
    {
        //public Book(string title, string isbn)
        //{
        //    Title = title;
        //    ISBN = isbn;
        //}

        //#region HIGHLIGHT
        //public Book(
        //    int id, string firstName, string lastName)
        //    : this(firstName, lastName)
        //#endregion HIGHLIGHT
        //{
        //    Id = id;
        //}

        public Book()
        {
            //Isbn = isbn;
            //Title = title;

            // Look up employee name...
            // ...
        }

        [SetsRequiredMembers]
        public Book(int id)
        {
            Isbn = "ISBN";
            Title = "title";

            // Look up employee name...
            // ...
        }

        //#pragma warning disable CS8618
        [SetsRequiredMembers]
        public Book(string isbn)
        {
            Isbn = isbn;

            // Look up employee name...
            // ...
            Title = "Title";
        }
        //#pragma warning restore CS8618

        // public int Id { get; init; }
        string? _Title;
        public required string Title 
        { get
            { 
                return _Title!; 
            } 
            set
            {
                ArgumentException.ThrowIfNullOrEmpty(
                    value = value?.Trim()!);
                _Title = value;
            }
        }
        string? _Isbn;
        public required string Isbn
        {
            get
            {
                return _Isbn!;
            }
            set
            {
                ArgumentException.ThrowIfNullOrEmpty(
                    value = value?.Trim()!);
                _Isbn = value;
            }
        }
        public string? Subtitle { get; set; } = "Not Enough";

        // ...
    }
    #endregion INCLUDE
}
#endif // NET7_0_OR_GREATER