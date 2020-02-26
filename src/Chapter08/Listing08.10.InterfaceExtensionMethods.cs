namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_10
{
    using System;
    using Listing08_02;

    public class Program
    {
        public static void Main()
        {
            Contact[] contacts = new Contact[] {
                new Contact(
                    "Dick", "Traci",
                    "123 Main St., Spokane, WA  99037",
                    "123-123-1234")
                // ...
            };


        // Classes are implicitly converted to
        // their supported interfaces
        contacts.List(Contact.Headers);

            Console.WriteLine();

            Publication[] publications = new Publication[3] {
                new Publication("Celebration of Discipline",
                    "Richard Foster", 1978),
                new Publication("Orthodoxy", 
                    "G.K. Chesterton", 1908),
                new Publication(
                    "The Hitchhiker's Guide to the Galaxy",
                    "Douglas Adams", 1979)
                };
            publications.List(Publication.Headers);
        }
    }

    static class Listable
    {
        public static void List(
            this IListable[] items, string[] headers)
        {
            int[] columnWidths = DisplayHeaders(headers);

            for(int itemCount = 0; itemCount < items.Length; itemCount++)
            {
                if (items[itemCount] != null)
                {
                    string?[] values = items[itemCount].CellValues;

                    DisplayItemRow(columnWidths, values);
                }
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
                string? itemToPrint = values[index]?.PadRight(columnWidths[index], ' ');
                Console.Write(itemToPrint);
            }
            Console.WriteLine();
        }
    }
}
