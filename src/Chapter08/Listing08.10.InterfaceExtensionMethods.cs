namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_10;

using System;
using Listing08_02;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Contact[] contacts = new Contact[] {
            new(
                "Dick", "Traci",
                "123 Main St., Spokane, WA  99037",
                "123-123-1234")
            // ...
        };

        #region HIGHLIGHT
        // 类隐式转换为它们支持的接口
        contacts.List(Contact.Headers);
        #endregion HIGHLIGHT

        Console.WriteLine();

        Publication[] publications = new Publication[3] {
            new("The End of Poverty: Economic Possibilities for Our Time",
                "Jeffrey Sachs", 2006),
            new("Orthodoxy", 
                "G.K. Chesterton", 1908),
            new(
                "The Hitchhiker's Guide to the Galaxy",
                "Douglas Adams", 1979)
            };
        #region HIGHLIGHT
        publications.List(Publication.Headers);
        #endregion HIGHLIGHT
    }
}

public static class Listable
{
    #region HIGHLIGHT
    public static void List(
        this IListable[] items, string[] headers)
    #endregion HIGHLIGHT
    {
        int[] columnWidths = DisplayHeaders(headers);

        for(int itemCount = 0; itemCount < items.Length; itemCount++)
        {
            if (items[itemCount] is not null)
            {
                string?[] values = items[itemCount].CellValues;

                DisplayItemRow(columnWidths, values);
            }
        }
    }
    #region EXCLUDE
    /// <summary>显示列标题</summary>
    /// <returns>返回由列宽构成的一个数组</returns>
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
                "列宽值的数量必须与要打印的值的数量匹配");
        }

        for(int index = 0; index < values.Length; index++)
        {
            string? itemToPrint = values[index]?.PadRight(columnWidths[index], ' ');
            Console.Write(itemToPrint);
        }
        Console.WriteLine();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
