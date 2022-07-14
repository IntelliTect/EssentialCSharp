namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_14
{
    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            string[] groceryList;
            System.Console.Write("How many items on the list? ");
            int size = int.Parse(System.Console.ReadLine());
            groceryList = new string[size];
            // ...
            #endregion INCLUDE
        }
    }
}
