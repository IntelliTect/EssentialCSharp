#if NET7_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35A
{
    #region INCLUDE
    public class Book
    {
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
                ArgumentException.ThrowIfNullOrEmpty(
                    value = value?.Trim()!);
                _Title = value;
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
                ArgumentException.ThrowIfNullOrEmpty(
                    value = value?.Trim()!);
                _Isbn = value;
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
                Isbn= "978-0135972267",
                Title= "Harold and the Purple Crayon"
            };
            #region EXCLUDE
            #pragma warning restore IDE0059 // Unnecessary assignment of a value
            #endregion EXCLUDE
        }
    }
    #endregion INCLUDE
}
#endif // NET7_0_OR_GREATER