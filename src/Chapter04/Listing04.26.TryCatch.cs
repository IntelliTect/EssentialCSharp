namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22
{
    public class LeveragingTryParse
    {
        public static int Main()
        {
            string firstName;
            string ageText;
            int age;
            int result = 0;

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your age: ");
            ageText = System.Console.ReadLine();

            if(int.TryParse(ageText, out age))
            {
                System.Console.WriteLine(
                    $"Hi { firstName }!  You are { age * 12 } months old.");
            }
            else
            {
                System.Console.WriteLine(
                    $"The age entered ,{ ageText }, is not valid.");
            }

            return result;
        }
    }
}
