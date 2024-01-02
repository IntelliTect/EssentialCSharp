namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_56;

using System;

#region INCLUDE
// CommandLine类嵌套在Program类中
#region HIGHLIGHT
public class Program
{
    // 定义一个嵌套类来专门处理命令行
    private class CommandLine
    {
#endregion HIGHLIGHT
        public CommandLine(string[] arguments)
        {
            for (int argumentCounter = 0;
                argumentCounter < arguments.Length;
                argumentCounter++)
            {
                _ = argumentCounter switch
                {
                    0 => Action = arguments[0].ToLower(),
                    1 => Id = arguments[1],
                    2 => FirstName = arguments[2],
                    3 => LastName = arguments[3],
                    _ => throw new ArgumentException(
                        $"非预期的参数" +
                        $"'{arguments[argumentCounter]}'")
                };
            }
        }
        public string? Action { get; }
        public string? Id { get; }
        public string? FirstName { get; }
        public string? LastName { get; }
    }

    public static void Main(string[] args)
    {
        #region HIGHLIGHT
        CommandLine commandLine = new(args);
        #endregion HIGHLIGHT

        // 为避免分心，这里故意省略了错误处理

        switch (commandLine.Action)
        {
            case "new":
                // 新建一个员工
                #region EXCLUDE
                Console.WriteLine("'正在创建'新员工。");
                #endregion EXCLUDE
                break;
            case "update":
                // 更新现有员工的数据
                #region EXCLUDE
                Console.WriteLine("'正在更新'员工。");
                #endregion EXCLUDE
                break;
            case "delete":
                // 删除现有员工的文件
                #region EXCLUDE
                Console.WriteLine("'正在删除'员工。");
                #endregion EXCLUDE
                break;
            default:
                Console.WriteLine(
                    "Employee.exe " +
                    "new|update|delete " +
                    "<id> [名字] [姓氏]");
                break;
        }
    }
}
#endregion INCLUDE
