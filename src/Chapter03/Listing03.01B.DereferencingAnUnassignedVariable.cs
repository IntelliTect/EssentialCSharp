namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01B
{
    // NOTE:    This file is referenced in Chapter03.csproj not to compile in order to prevent 
    //          the build from failing.

    public class Program
    {
        public static void Main()
        {
            string? text;
            // ...
            // Compile Error: Use of unassigned local variable 'text'
            System.Console.WriteLine(text.length);
        }
    }
}
