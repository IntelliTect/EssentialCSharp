namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_28
{
    public class LeveragingTryParse
    {
        public static void Main()
        {
            string firstName;
            string ageText;

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your age: ");
            ageText = System.Console.ReadLine();

#if !PRECSHARP7
            if (int.TryParse(ageText, out int age))
#else
            int age;
            if(int.TryParse(ageText, out age))
#endif // !PRECSHARP7
            {
                System.Console.WriteLine(
                    $"Hi { firstName }! You are { age * 12 } months old.");
            }
            else
            {
                System.Console.WriteLine(
                    $"The age entered ,{ ageText }, is not valid.");
            }
        }
    }
}
