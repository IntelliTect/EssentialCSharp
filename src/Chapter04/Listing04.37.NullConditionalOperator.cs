namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_37
{
    public class Program
    {
        public static string[]? Segments { get; set; }

        static public void Main(string[] args)
        {

            string[]? segments = null;

            // ...
            segments = Segments;  // Included to support unit testing.

            string? uri = null;

            int? length = segments?.Length;
            if (length is { } && length != 0)
            {
                uri = string.Join('/', segments!);
            }

            // Null-conditional with array accessor
            // uri = segments?[0];
                

            if (uri is null || length is 0)
            {
                System.Console.WriteLine(
                    "There were no segments to combine.");
            }
            else
            {
                System.Console.WriteLine(
                    $"Uri: { uri }");
            }
        }
    }
}
