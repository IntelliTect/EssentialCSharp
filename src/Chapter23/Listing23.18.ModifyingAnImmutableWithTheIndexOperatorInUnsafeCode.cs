namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_18
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
                    pText[1] = 'm';
                    pText[2] = 'i';
                    pText[3] = 'l';
                    pText[4] = 'e';
                    pText[5] = ' ';
                    pText[6] = ' ';
                }
            }
            Console.WriteLine(text);
        }
    }
}
