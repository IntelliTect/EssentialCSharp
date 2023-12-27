#region INCLUDE
// global using指令将指定全名空间的所有类型“导入”项目
global using System.Text;
#region EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_10;
#endregion EXCLUDE
public class Program
{
    public static void Main()
    {
        // new();的用法请参见第6章
        StringBuilder name = new();

        Console.Write("请输入你的名字: ");         
        name.Append(Console.ReadLine()!.Trim());

        Console.Write("请输入你的中间名首字母: ");
        name.Append( $" { Console.ReadLine()!.Trim('.').Trim() }." );

        Console.Write("请输入你的姓氏: ");
        name.Append($" { Console.ReadLine()!.Trim() }");

        Console.WriteLine($"你好，{name}！");
    }
}
#endregion INCLUDE
