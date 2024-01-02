namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_13;

using Listing06_12;
#region INCLUDE
public class DataStorage
{
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
    // ...
}
#endregion INCLUDE
