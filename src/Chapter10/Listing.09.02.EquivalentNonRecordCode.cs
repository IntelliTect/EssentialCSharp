using System.Runtime.CompilerServices;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

[CompilerGenerated]
public class Book : IEquatable<Book>
{
    public string? Title { get; init; }

    public string? Author { get; init; }

    public string? Isbn { get; init; }

    public Book(string? Title, string? Author, string? Isbn)
    {
        this.Title = Title;
        this.Author = Author;
        this.Isbn = Isbn;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append("Book");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(' ');
        }
        stringBuilder.Append('}');
        return stringBuilder.ToString();
    }

    protected virtual bool PrintMembers(StringBuilder builder)
    {
        RuntimeHelpers.EnsureSufficientExecutionStack();
        builder.Append("Title = ");
        builder.Append((object?)Title);
        builder.Append(", Author = ");
        builder.Append((object?)Author);
        builder.Append(", Isbn = ");
        builder.Append((object?)Isbn);
        return true;
    }

    protected Book(Book original)
    {
        Title = original.Title;
        Author = original.Author;
        Isbn = original.Isbn;
    }

    public void Deconstruct(out string? Title, out string? Author, out string? Isbn)
    {
        Title = this.Title;
        Author = this.Author;
        Isbn = this.Isbn;
    }

    public static bool operator !=(Book left, Book right)
    {
        return !(left == right);
    }

    public static bool operator ==(Book left, Book right)
    {
        return (object)left == right || (left?.Equals(right) ?? false);
    }

    public override int GetHashCode()
    {
        return ((
            EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Title!)) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Author!)) * -1521134295 + 
            EqualityComparer<string>.Default.GetHashCode(Isbn!);
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Book);
    }

    public virtual bool Equals(Book? other)
    {
        return (object)this == other || (other is not null && 
            EqualityContract == other.EqualityContract && 
            EqualityComparer<string>.Default.Equals(Title, other.Title) && 
            EqualityComparer<string>.Default.Equals(Author, other.Author) && 
            EqualityComparer<string>.Default.Equals(Isbn, other.Isbn));
    }

    protected virtual Type EqualityContract
    {
        get
        {
            return typeof(Book);
        }
    }
}

