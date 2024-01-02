#if NET7_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_40;

public class Program
{
    public static void Main()
    {
        Book book = new(42) { 
            Subtitle = "����ҵ�񳡾��Ĺ���Ӧ��"};
    }
}

public class Book
{
    #region INCLUDE
    [SetsRequiredMembers]
    public Book(int id)
    {
        Id = id;

        // �����鼮����
        #region EXCLUDE
        Title = string.Empty;
        Isbn = string.Empty;
        #endregion EXCLUDE
        // ...
    }
    #endregion INCLUDE

    public int Id { get; init; }

    string? _Title;
    public required string Title
    {
        get
        {
            return _Title!;
        }
        set
        {
            ArgumentException.ThrowIfNullOrEmpty(value);
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
            ArgumentException.ThrowIfNullOrEmpty(value);
            _Isbn = value;
        }
    }
    public string? Subtitle { get; set; }

    // ...
}
#endif // NET7_0_OR_GREATER
