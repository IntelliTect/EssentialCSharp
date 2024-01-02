// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_14;

#region INCLUDE
using System;
// IO命名空间
using System.IO;

public class Employee
{
    #region EXCLUDE
    public string FirstName;
    public string LastName;
    public string? Salary;

    public string GetName()
    {
        return $"{ FirstName } { LastName }";
    }

    public void SetName(string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        Console.WriteLine(
            $"姓名更改为'{ this.GetName() }'");
    }

    public void Save()
    {
        DataStorage.Store(this);
    }
    #endregion EXCLUDE
}

public class DataStorage
{
    #region EXCLUDE
    // 将Employee对象写入一个以员工姓名命名的文件；
    // 这里未显示错误处理的情况。
    public static void Store(Employee employee)
    {
        // 使用<名字><姓氏>.dat作为文件名来实例化一个FileStream。
        // FileMode.Create将强制创建一个新文件，或者覆盖一个已存在的文件。
        // 注意：这段代码可以通过使用using语句来改进——我们目前尚未讲到的一种构造。
        FileStream stream = new(
            employee.FirstName + employee.LastName + ".dat",
            FileMode.Create);

        // 创建一个StreamWriter对象writer，以便将文本写入FileStream对象stream
        StreamWriter writer = new(stream);

        // 开始写入与员工实例关联的所有数据
        writer.WriteLine(employee.FirstName);
        writer.WriteLine(employee.LastName);
        writer.WriteLine(employee.Salary);

        // 对StreamWriter及其流进行资源清理(dispose)
        writer.Dispose();  // 会自动关闭流
    }
    #endregion EXCLUDE

    public static Employee Load(string firstName, string lastName)
    {
        Employee employee = new();

        // 使用<名字><姓氏>.dat作为文件名来实例化一个FileStream。
        // FileMode.Open将打开一个已存在的文件；不存在会报错。
        FileStream stream = new(
            firstName + lastName + ".dat", FileMode.Open);

        // 创建一个StreamReader，以便从文件中读取文本
        StreamReader reader = new(stream);

        // 读取文件的每一行，并将其赋给关联的属性        
        employee.FirstName = reader.ReadLine()??
            throw new InvalidOperationException(
                "FirstName不能为null");
        employee.LastName = reader.ReadLine()??
            throw new InvalidOperationException(
                "LastName不能为null");
        employee.Salary = reader.ReadLine();

        // 对StreamReader及其流进行资源清理(dispose)
        reader.Dispose();  // 会自动关闭流

        return employee;
    }
}

public class Program
{
    public static void Main()
    {
        Employee employee1;

        Employee employee2 = new();
        employee2.SetName("Inigo", "Montoya");
        employee2.Save();

        // 保存后修改employee2
        IncreaseSalary(employee2);

        // 从保存的employee2版本中，将数据加载到employee1
        employee1 = DataStorage.Load("Inigo", "Montoya");

        Console.WriteLine(
            $"{ employee1.GetName() }: { employee1.Salary }");
    }
    #region EXCLUDE
    public static void IncreaseSalary(Employee employee)
    {
        employee.Salary = "勉强过活";
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
