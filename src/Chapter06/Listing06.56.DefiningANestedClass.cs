namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_56;

using System;

#region INCLUDE
// CommandLine��Ƕ����Program����
#region HIGHLIGHT
public class Program
{
    // ����һ��Ƕ������ר�Ŵ���������
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
                        $"��Ԥ�ڵĲ���" +
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

        // Ϊ������ģ��������ʡ���˴�����

        switch (commandLine.Action)
        {
            case "new":
                // �½�һ��Ա��
                #region EXCLUDE
                Console.WriteLine("'���ڴ���'��Ա����");
                #endregion EXCLUDE
                break;
            case "update":
                // ��������Ա��������
                #region EXCLUDE
                Console.WriteLine("'���ڸ���'Ա����");
                #endregion EXCLUDE
                break;
            case "delete":
                // ɾ������Ա�����ļ�
                #region EXCLUDE
                Console.WriteLine("'����ɾ��'Ա����");
                #endregion EXCLUDE
                break;
            default:
                Console.WriteLine(
                    "Employee.exe " +
                    "new|update|delete " +
                    "<id> [����] [����]");
                break;
        }
    }
}
#endregion INCLUDE
