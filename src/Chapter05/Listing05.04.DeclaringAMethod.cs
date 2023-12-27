namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_04;

#region INCLUDE
public class IntroducingMethods
{
    public static void Main()
    {
        string firstName;
        string lastName;
        string fullName;
        string initials;

        Console.WriteLine("嘿，你！");

        firstName = GetUserInput("请输入你的名字: ");
        lastName = GetUserInput("请输入你的姓氏: ");

        fullName = GetFullName(firstName, lastName);
        initials = GetInitials(firstName, lastName);
        DisplayGreeting(fullName, initials);
    }

    static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? string.Empty;
    }

    static string GetFullName(  
          string firstName, string lastName) =>
              $"{ firstName } { lastName }";


    static void DisplayGreeting(string fullName, string initials)
    {
        Console.WriteLine(
            $"你好，{ fullName }！你的姓名缩写是{ initials }");
        return;
    }

    static string GetInitials(string firstName, string lastName)
    {
        return $"{ firstName[0] }. { lastName[0] }";
    }
}
#endregion INCLUDE
