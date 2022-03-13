namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_28
{
    // TODO: Update listing in Manuscript
    using System;

    public class LeveragingTryParse
    {
        public static void Main()
        {
            string? firstName;
            string ageText;

            Console.Write("Enter your first name: ");
            // TODO: Update listing in Manuscript
            firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            // TODO: Update listing in Manuscript
            // Assume not null for clarity
            ageText = Console.ReadLine()!;

#if !PRECSHARP7
            if (int.TryParse(ageText, out int age))
#else
            int age;
            if(int.TryParse(ageText, out age))
#endif // !PRECSHARP7
            {
                Console.WriteLine(
                    $"Hi { firstName }! You are { age * 12 } months old.");
            }
            else
            {
                Console.WriteLine(
                    $"The age entered ,{ ageText }, is not valid.");
            }
        }
    }
}
