using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_21
{
    #region INCLUDE
    public class Person
    {
        #region EXCLUDE
        public Person(string firstName, string lastName)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
        public string FirstName { get; }
        public string LastName { get; }
        #endregion EXCLUDE

        #region HIGHLIGHT
        public void Deconstruct(out string firstName, out string lastName) =>
            (firstName, lastName) = (FirstName, LastName);
        #endregion HIGHLIGHT
    }

    public class Program
    {
        public static void Main()
        {
            Person person = new Person("Inigo", "Montoya");

            // Positional Pattern Matching
            #region HIGHLIGHT
            if (person is (string firstName, string lastName))
            #endregion HIGHLIGHT
            {
                Console.WriteLine($"{firstName} {lastName}");
            }
        }
    }
    #endregion INCLUDE
}
