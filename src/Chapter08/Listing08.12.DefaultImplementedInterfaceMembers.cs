namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_12;

using System;

public class Program
{
    public static void Main()
    {
        Contact[] contacts = new Contact[]
        {
          new(
              "Dick", "Traci",
              "123 Main St., Spokane, WA  99037",
              "123-123-1234"),
          new(
              "Andrew", "Littman",
              "1417 Palmary St., Dallas, TX 55555",
              "555-123-4567"),
          new(
              "Mary", "Hartfelt",
              "1520 Thunder Way, Elizabethton, PA 44444",
              "444-123-4567"),
          new(
              "John", "Lindherst",
              "1 Aerial Way Dr., Monteray, NH 88888",
              "222-987-6543"),
          new(
              "Pat", "Wilson",
              "565 Irving Dr., Parksdale, FL 22222",
              "123-456-7890"),
          new(
              "Jane", "Doe",
              "123 Main St., Aurora, IL 66666",
              "333-345-6789")
        };

        // Classes are cast implicitly to
        // their supported interfaces
        ConsoleListControl.List(Contact.Headers, contacts);

        Console.WriteLine();

        Publication[] publications = new Publication[3] {
            new(
                "The End of Poverty: Economic Possibilities for Our Time",
                "Jeffrey Sachs", 2006),
            new("Orthodoxy",
                "G.K. Chesterton", 1908),
            new(
                "The Hitchhiker's Guide to the Galaxy",
                "Douglas Adams", 1979)
            };
        ConsoleListControl.List(
            Publication.Headers, publications);
    }
}

#region INCLUDE
public interface IListable
{
    // Return the value of each cell in the row
    string?[] CellValues
    {
        get;
    }

    #region HIGHLIGHT
    ConsoleColor[] CellColors
    {
        get
    #endregion HIGHLIGHT
        {
            var result = new ConsoleColor[CellValues.Length];
            // Using generic Array method to populate array
            // (see Chapter 12)
            Array.Fill(result, DefaultColumnColor);
            return result;
        }
    }
    #region HIGHLIGHT
    public static ConsoleColor DefaultColumnColor { get; set; }
    #endregion HIGHLIGHT
}

#region EXCLUDE
public abstract class PdaItem
{
    public PdaItem(string name)
    {
        Name = name;
    }

    public virtual string Name { get; set; }
}
#endregion EXCLUDE

public class Contact : PdaItem, IListable
{
    #region EXCLUDE
    public Contact(string firstName, string lastName,
        string address, string phone)
        : base(GetName(firstName, lastName))
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Phone = phone;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    #endregion EXCLUDE

    #region IListable
    string[] IListable.CellValues
    {
        get
        {
            return new string[]
            {
                FirstName,
                LastName,
                Phone,
                Address
            };
        }
    }
    #region HIGHLIGHT
    // *** No CellColors implementation *** //
    #endregion HIGHLIGHT
    #endregion IListable

    #region EXCLUDE
    public static string[] Headers
    {
        get
        {
            return new string[] {
                "First Name", "Last Name    ",
                "Phone       ",
                "Address                       " };
        }
    }

    public static string GetName(string firstName, string lastName)
        => $"{ firstName } { lastName }";
    #endregion EXCLUDE
}

public class Publication : IListable
{
    #region EXCLUDE
    public Publication(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    private const int YearIndex = 2;
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public static string[] Headers
    {
        get
        {
            return new string[] {
                "Title                                                    ",
                "Author             ",
                "Year" };
        }
    }
    #endregion EXCLUDE

    #region IListable
    string?[] IListable.CellValues
    {
        get
        {
            return new string[]
            {
                Title,
                Author,
                Year.ToString()
            };
        }
    }

    #region HIGHLIGHT
    ConsoleColor[] IListable.CellColors
    {
        get
        {
            string?[] columns = ((IListable)this).CellValues;
            ConsoleColor[] result = ((IListable)this).CellColors;
            if (columns[YearIndex]?.Length != 4)
            {
                result[YearIndex] = ConsoleColor.Red;
            }
            return result;
        }
    }
    #endregion HIGHLIGHT
    #endregion IListable
    // ...
}
#endregion INCLUDE


public class ConsoleListControl
{
    public static void List(string[] headers, IListable[] items)
    {
        int[] columnWidths = DisplayHeaders(headers);

        for (int count = 0; count < items.Length; count++)
        {
            DisplayItemRow(columnWidths, items[count]);
        }
    }

    /// <summary>Displays the column headers</summary>
    /// <returns>Returns an array of column widths</returns>
    private static int[] DisplayHeaders(string[] headers)
    {
        var columnWidths = new int[headers.Length];
        for (int index = 0; index < headers.Length; index++)
        {
            Console.Write(headers[index]);
            columnWidths[index] = headers[index].Length;
        }
        Console.WriteLine();
        return columnWidths;
    }

    private static void DisplayItemRow(
        int[] columnWidths, IListable item)
    {
        string?[] columnValues = item.CellValues;
        if (columnWidths.Length != columnValues.Length)
        {
            throw new ArgumentOutOfRangeException(
                $"{ nameof(columnWidths) },{ nameof(item) }.{nameof(item.CellColors) }",
                "The number of column widths must match the number of values to print");
        }

        // Exception handling excluded for elucidation
        ConsoleColor originalColor = Console.ForegroundColor;
        ConsoleColor[] itemColors = ((IListable)item).CellColors;
        for (int index = 0; index < columnValues.Length; index++)
        {
            string itemToPrint = (columnValues[index] ?? "").PadRight(columnWidths[index], ' ');
            Console.ForegroundColor = itemColors[index];
            Console.Write(itemToPrint);
        }
        Console.ForegroundColor = originalColor;
        Console.WriteLine();
    }
}
