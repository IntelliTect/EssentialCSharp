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
              ( // 元组: 从Person的解构函数获取
                ( // 位置: 选择左侧或元组
                    { // firstName的属性
                        Length: int inigoFirstNameLength
                    }, 
                 _ // 丢弃元组的姓氏部分
                ),
                { // Princess Buttercup元组的属性
                    FirstName: string buttercupFirstName
                }
              )
            )
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
