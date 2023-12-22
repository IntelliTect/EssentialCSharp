namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_21;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string firstName = "Forest";

        // ����ԭʼ�ַ�������ֵ
        string lastName = """Gump""";

        // ����ֵ�ĵ���ԭʼ�ַ�������ֵ
        string greeting =
        $"""��ã�����{firstName}��{firstName} {lastName}��""";

        string proposal = "����Ҫһ���ɿ�����"
            + "���ܳԵ��ϰ�����ɿ�����";

        string mamaSaid = // ����ԭʼ�ַ�������ֵ
            """
                ����˵��"�������һ���ɿ���..."
                """;

        string jsonDialogue =

            // ����ֵ�Ķ���ԭʼ�ַ�������ֵ

            $$"""
                {
                    "quote": {
                        "character": "The MAN",
                        "dialogue": "{{greeting}}"
                     },
                    "description" : "�����ͷ����Ȥ������...",
                    "quote": {
                        "character": "The MAN",
                        "dialogue": "{{proposal}}"
                     },
                     "description" : "��ҡҡͷ\"��\" ���򿪺���...",
                     "quote": {
                        "character": "The MAN",
                         "dialogue": "{{mamaSaid.Replace("\"", "\\\"")}}"
                      }
                }
                """;
        Console.WriteLine(jsonDialogue);
        #endregion INCLUDE
    }
}

