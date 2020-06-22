namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05
{
    public class DisplayFibonacci
    {
        static void Main()
        {
            // ...

            int number;
            object thing;
            double bigNumber;

            number = 42;
            thing = number;
            // ERROR: InvalidCastException
            // bigNumber = (double)thing;
            bigNumber = (double)(int)thing;

            // ...
        }
    }
}
