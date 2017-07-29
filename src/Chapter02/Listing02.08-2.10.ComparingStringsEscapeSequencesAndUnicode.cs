namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_08
{
    public class SingleQuote
    {
        public static void Main()
        {
            //begin 2.8
            string option = "";

            int comparison = string.Compare(option, "/Help", true);
            //end 2.8

            //begin 2.9
            System.Console.WriteLine('\'');
            //end 2.9

            //begin2.10
            System.Console.Write('\u003A');
            System.Console.WriteLine('\u0029');
            //end 2.10
        }
    }
}
