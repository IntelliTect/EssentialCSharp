namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_20;

#region INCLUDE
public class Person
{
    #region EXCLUDE
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
    #endregion EXCLUDE
}

public class Employee : Person
{
    #region EXCLUDE
    public Employee(string firstName, string lastName, string id) : base(firstName, lastName)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
    }
    public string Id { get; }
    #endregion EXCLUDE
}

public class Program
{
    private static object? GetObjectById(string id)
    {
        #region EXCLUDE
        if(id is null) throw new ArgumentNullException("id");

        if (id.StartsWith(nameof(Employee)))
        {
            return new Employee("Inigo", "Montoya", id.Remove(0,nameof(Employee).Length));
        }
        else if (id.StartsWith(nameof(Person)))
        {
            return new Person("Inigo", "Montoya");
        }
        return id;
        #endregion EXCLUDE
    }

    public static void Main(params string[] args)
    {
        string id = args[0];
        object? entity = GetObjectById(id);

        #region HIGHLIGHT
        if (entity is Person)
        {
            Person person = (Person) entity;
        #endregion HIGHLIGHT
            Console.WriteLine(
                $"Id��Ӧ��һ��{
                    nameof(Person) }����: {
                    person.FirstName} {
                    person.LastName}��"
                );

            #region HIGHLIGHT
            if (entity is Employee employee)
            #endregion HIGHLIGHT
            {
                Console.WriteLine(
                    $"Id({ employee.Id })Ҳ��һ��{
                        nameof(Employee)}����");
            }
        }
        else if(entity is null)
        {
            Console.WriteLine(
                $"Idδ֪�����Է���null��");
        }
        else
        {
            Console.WriteLine(
                $"Id'{id}'����һ��{
                    nameof(Employee)}��{nameof(Person)}����");
        }
    }
}
#endregion INCLUDE
