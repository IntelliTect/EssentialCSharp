namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_21;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string firstName = "Forest";

        // 单行原始字符串字面值
        string lastName = """Gump""";

        // 带插值的单行原始字符串字面值
        string greeting =
        $"""你好，我是{firstName}。{firstName} {lastName}。""";

        string proposal = "你想要一块巧克力吗？"
            + "我能吃掉上百万块巧克力。";

        string mamaSaid = // 多行原始字符串字面值
            """
                妈妈说："生活就像一盒巧克力..."
                """;

        string jsonDialogue =

            // 带插值的多行原始字符串字面值

            $$"""
                {
                    "quote": {
                        "character": "The MAN",
                        "dialogue": "{{greeting}}"
                     },
                    "description" : "她点点头，兴趣不大。他...",
                    "quote": {
                        "character": "The MAN",
                        "dialogue": "{{proposal}}"
                     },
                     "description" : "她摇摇头\"不\" 他打开盒子...",
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

