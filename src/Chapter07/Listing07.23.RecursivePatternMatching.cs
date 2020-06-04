using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_23
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName ??
                throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ??
                throw new ArgumentNullException(nameof(lastName));
        }
        public string FirstName { get; }
        public string LastName { get; }

        public void Deconstruct(out string firstName, out string lastName) =>
            (firstName, lastName) = (FirstName, LastName);
    }
    public class Program
    {
        public static void Main()
        {
            Person inigo = new Person("Inigo", "Montoya");
            var buttercup = 
                (FirstName: "Princess", LastName: "Buttercup");

            (Person, (string FirstName, string LastName)) couple = (inigo, buttercup);

            if (couple is 
                ( // Tuple
                    ( // Positional
                        { // Property
                            Length: int inigoLength1 }, 
                     _ // Discard
                    ),
                { // Property
                    FirstName: string buttercupFirstName }))
            {
                Console.WriteLine($"({inigoLength1}, {buttercupFirstName})");
            }
        }
    }
}
