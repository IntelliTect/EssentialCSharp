namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_37
{
    public class Program
    {
        public static void Main()
        {
            string[] groceryList;
            System.Console.Write("How many items on the list? ");
            int size = int.Parse(System.Console.ReadLine());
            groceryList = new string[size];
            // ...
        }
    }
}
