#if NET7_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_34C
{
    public class Program
    {
        public static void Main()
        {
            Book book = new(42) { 
                /*Isbn= "Essential C#",*/ Title= "978-0135972267" };
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
        [SetsRequiredMembers]
        public Book(int id)
        {
            Id = id;

            // Look up employee data
            #region EXCLUDE
            Title = string.Empty;
            //Isbn = string.Empty;
            #endregion EXCLUDE
            // ...
        }
        public int Id { get; init; }

        //#pragma warning disable CS8618
        //#pragma warning restore CS8618
        //public Book()
        //{
        //    // Look up employee name...
        //    // ...
        //}

        string? _Title;
        public required string Title
        {
            get
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