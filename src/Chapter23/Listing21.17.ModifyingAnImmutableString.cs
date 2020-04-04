namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_17
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = "S5280ft";
            Console.Write("{0} = ", text);
            unsafe // Requires /unsafe switch
            {
                fixed(char* pText = text)
                {
                    char* p = pText;
                    *++p = 'm';
                    *++p = 'i';
                    *++p = 'l';
                    *++p = 'e';
                    *++p = ' ';
                    *++p = ' ';
                }
            }
            Console.WriteLine(text);
        }
    }
}
