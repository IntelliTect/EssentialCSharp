//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02
//{
    public class Program
    {
        public static void Main()
        {
            string? text;
            // ...

            // Compile Error: Use of unassigned local variable 'text'
            System.Console.WriteLine(text.Length);
        }
    }
//}
