namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_02
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Contact[] contacts = new Contact[]
            {
              new Contact(
                  "Dick", "Traci",
                  "123 Main St., Spokane, WA  99037",
                  "123-123-1234"),
              new Contact(
                  "Andrew", "Littman",
                  "1417 Palmary St., Dallas, TX 55555",
                  "555-123-4567"),
              new Contact(
                  "Mary", "Hartfelt",
                  "1520 Thunder Way, Elizabethton, PA 44444",
                  "444-123-4567"),
              new Contact(
                  "John", "Lindherst",
                  "1 Aerial Way Dr., Monteray, NH 88888",
                  "222-987-6543"),
              new Contact(
                  "Pat", "Wilson",
                  "565 Irving Dr., Parksdale, FL 22222",
                  "123-456-7890"),
              new Contact(
                  "Jane", "Doe",
                  "123 Main St., Aurora, IL 66666",
                  "333-345-6789")
            };

            // Classes are cast implicitly convertible to
            // their supported interfaces
            ConsoleListControl.List(Contact.Headers, contacts);

            Console.WriteLine();

            Publication[] publications = new Publication[3] {
                new Publication(
                    "The End of Poverty: Economic Possibilities for Our Time",
                    "Jeffrey Sachs", 2006),
                new Publication("Orthodoxy", 
                    "G.K. Chesterton", 1908),
                new Publication(
                    "The Hitchhiker's Guide to the Galaxy",
                    "Douglas Adams", 1979)
                };
            ConsoleListControl.List(
                Publication.Headers, publications);
        }
    }

    public interface IListable
    {
        // Return the value of each cell in the row
        string?[] CellValues
        {
            get;
        }
    }

    public abstract class PdaItem
    {
        public PdaItem(string name)
        {
            Name = name;
        }

        public virtual string Name { get; set; }
    }

    public class Contact : PdaItem, IListable
    {
        public Contact(string firstName, string lastName,
            string address, string phone)
            : base(GetName(firstName, lastName))
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string Phone { get; }

        public string[] CellValues
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

        static public string GetName(string firstName, string lastName)
            => $"{ firstName } { lastName }";
    }

    public class Publication : IListable
    {
        public Publication(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public string Title { get; }
        public string Author { get; }
        public int Year { get; }

        public string?[] CellValues
        {
            get
            {
                return new string?[]
                {
                    Title,
                    Author,
                    Year.ToString()
                };
            }
        }

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

        // ...
    }


    public class ConsoleListControl
    {
        public static void List(string[] headers, IListable[] items)
        {
            int[] columnWidths = DisplayHeaders(headers);

            for(int count = 0; count < items.Length; count++)
            {
                string?[] values = items[count].CellValues;
                DisplayItemRow(columnWidths, values);
            }
        }

        /// <summary>Displays the column headers</summary>
        /// <returns>Returns an array of column widths</returns>
        private static int[] DisplayHeaders(string[] headers)
        {
            var columnWidths = new int[headers.Length];
            for(int index = 0; index < headers.Length; index++)
            {
                Console.Write(headers[index]);
                columnWidths[index] = headers[index].Length;
            }
            Console.WriteLine();
            return columnWidths;
        }

        private static void DisplayItemRow(
            int[] columnWidths, string?[] values)
        {
            if(columnWidths.Length != values.Length)
            {
                throw new ArgumentOutOfRangeException(
                    $"{ nameof(columnWidths) },{ nameof(values) }",
                    "The number of column widths must match the number of values to print");
            }

            for(int index = 0; index < values.Length; index++)
            {
                string itemToPrint = (values[index]??"").PadRight(columnWidths[index], ' ');
                Console.Write(itemToPrint);
            }
            Console.WriteLine();
        }
    }
}
