// Ignored as implementation was removed for elucidation
#pragma warning disable IDE0060 //Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_58;

using System;

#region INCLUDE
// 文件: Program.cs
partial class Program
{
    static void Main(string[] args)
    {
        CommandLine commandLine = new(args);

        switch(commandLine.Action)
        {
            #region EXCLUDE
            default:
                break;
            #endregion EXCLUDE
        }
    }
}

// 文件: Program+CommandLine.cs
partial class Program
{
    // 定义一个嵌套类来处理命令行
    private class CommandLine
    {
        #region EXCLUDE
        public CommandLine(string[] args)
        {
            //未实现
        }

        // ...
        public int Action
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
