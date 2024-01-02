// ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
#pragma warning disable CS8618
// Our Main doesn't leverage everything in our Employee implementation - in production it would
#pragma warning disable CS0649
// Disabled pending introduction to object initializers
#pragma warning disable IDE0017 
// Add readonly modifier ignored pending introduction of the concept
#pragma warning disable IDE0044


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_15;

#region INCLUDE
public class Employee
{
    public string FirstName;
    public string LastName;
    public string? Salary;
    // ������ֱ��ʹ�ý��ܵ����������ʾ��ƽʱ���Ƽ��� 
    // δ��ʼ�����Ժ����͡����캯����
    #region HIGHLIGHT
    private string Password;  
    private bool IsAuthenticated;
    #endregion HIGHLIGHT

    #region HIGHLIGHT
    public bool Logon(string password)
    {
        if(Password == password)
        {
            IsAuthenticated = true;
        }
        return IsAuthenticated;
    }

    public bool GetIsAuthenticated()
    {
        return IsAuthenticated;
    }
    #endregion HIGHLIGHT
    // ...
}

public class Program
{
    public static void Main()
    {
        Employee employee = new();

        employee.FirstName = "Inigo";
        employee.LastName = "Montoya";

        // ...


#if COMPILEERROR // EXCLUDE
        #region HIGHLIGHT
        // ����: Password��˽�еģ����Բ��ܴ�����ⲿ����
        Console.WriteLine(
           "Password = {0}", employee.Password);
        #endregion HIGHLIGHT
#endif // COMPILEERROR // EXCLUDE
    }
    // ...
}
#endregion INCLUDE
