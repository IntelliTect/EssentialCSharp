namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_31;

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
        //// ...
        //(int x, int y) point = (42, -42);
        
        //string quadrant = point switch
        //{
        //    (>=0, >=0) => "Quadrant 1",
        //    (>0, <0) => "Quadrant 2",
        //    (<0, <0) => "Quadrant 3",
        //    (<0, >0) => "Quadrant 4",
        //};




        // ...
        #endregion INCLUDE
    }


    public static bool TryGetPhoneButton(char character, out char? button)
    {
        bool success = true;
        switch (char.ToLower(character))
        {
            case '1':
                button = '1';
                break;
            case >='a' and <='c' or '2':
                button = '2';
                break;
            case >='d' and <='f' or '3':
                button = '3';
                break;
            case >='g' and <='i' or '4':
                button = '4';
                break;
            case >='j' and <='l' or '5':
                button = '5';
                break;
            case >='m' and <='o' or '6':
                button = '6';
                break;
            case >='p' and <='s' or '7':
                button = '7';
                break;
            case >='t' and <='v' or '8':
                button = '8';
                break;
            case >='w' and <='z' or '9':
                button = '9';
                break;
            case '+':
                button = '0';
                break;
            case '-':
                button = '-';
                break;
            default:
                // Set the button to indicate an invalid value
                button = '_';
                success = false;
                break;
        }
        return success;
    }

    public static char GetPhoneButton(char character) =>
        char.ToLower(character) switch
        {
            '1' => '1',
            >='a' and <='c' or '2' => '2',
            >='d' and <='f' or '3' => '3',
            >='g' and <='i' or '4' => '4',
            >='j' and <='l' or '5' => '5',
            >='m' and <='o' or '6' => '6',
            >='p' and <='s' or '7' => '7',
            >='t' and <='v' or '8' => '8',
            >='w' and <='z' or '9' => '9',
            '+' => '0',
            '-' => '-',
            // Set the button to indicate an invalid value
            _ => '_',
        };
}

