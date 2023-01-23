using System.Diagnostics;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03;

public record class Book(string Title, string? Author, string Isbn)
{
    public string Title { get; } = Title??
        throw new ArgumentNullException(nameof(Title));

    private string _Author = Author??
        throw new ArgumentNullException(nameof(Author));
    public string Author
    {
        get => _Author;
        set => _Author=value??
            throw new ArgumentNullException(nameof(value));
    }

    private string _Isbn = Isbn??
        throw new ArgumentNullException(nameof(Isbn));
    public string Isbn
    {
        get => _Isbn;
        init => _Isbn=value??
            throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new(GetType().FullName);
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(' ');
        }
        stringBuilder.Append('}');
        return stringBuilder.ToString();
    }

    public virtual bool Equals(Book? other)
    {
        return ReferenceEquals(this, other) || (other is not null &&
            typeof(Book) == other.GetType() &&
            Isbn == other.Isbn);
    }

    public override int GetHashCode() => Isbn.GetHashCode();
}

