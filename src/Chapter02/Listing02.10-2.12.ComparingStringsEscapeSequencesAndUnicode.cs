namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10
{
    public class SingleQuote
    {
        public static void Main()
        {
            //begin 2.10
            string option = "";

            int comparison = string.Compare(option, "/Help", true);
            //end 2.10

            //begin 2.11
            System.Console.WriteLine('\'');
            //end 2.11

            //begin2.12
            System.Console.Write('\u003A');
            System.Console.WriteLine('\u0029');
            //end 2.12
        }
    }
}
