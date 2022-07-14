using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_22
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
            #region INCLUDE
            // ...
            Person person = new Person("Inigo", "Montoya");

            // Positional pattern matching
            #region HIGHLIGHT
            if (person is {FirstName: string firstName, LastName: string lastName })
            #endregion HIGHLIGHT
            {
                Console.WriteLine($"{firstName} {lastName}");
            }
            // ...
            #endregion INCLUDE
        }
    }
}
