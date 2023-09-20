namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_32;

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
        Person inigo = new("Inigo", "Montoya");
        var buttercup = 
            (FirstName: "Princess", LastName: "Buttercup");

        (Person inigo, (string FirstName, string LastName) buttercup) couple =
            (inigo, buttercup);

        if (couple is 
            ( // Tuple: Retrieved from deconstructor of Person
                ( // Positional: Select left side or tuple
                    { // Property of firstName
                        Length: int inigoFirstNameLength
                    }, 
                 _ // Discard last name portion of tuple
                ),
            { // Property of Princess Buttercup tuple
                FirstName: string buttercupFirstName }))
        {
            Console.WriteLine(
                $"({ inigoFirstNameLength }, { buttercupFirstName })");
        }
        else
        {
            // ...
        }
        // ...
        #endregion INCLUDE
    }
}
