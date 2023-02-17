namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_21;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string firstName = "Forest";

        // Single-line raw string literal.
        string lastName = """Gump""";

        // Single-line raw string literal with interpolation.
        string greeting =
        $"""Hello, I'm {firstName}. {firstName} {lastName}""";

        string proposal = "Do you want a chocolate?"
            + "I could eat about a million and a half of these.";

        string mamaSaid = // Multi-line raw string literal.
            """
                Mama said, "Life was just a box of chocolates..."
                """;

        string jsonDialogue =

            // Multi-line raw string literal with interpolation.

            $$"""
                {
                    "quote": {
                        "character": "The MAN",
                        "dialogue": "{{greeting}}"
                     },
                    "description" : "She nods, not much interested. He...",
                    "quote": {
                        "character": "The MAN",
                        "dialogue": "{{proposal}}"
                     },
                     "description" : "She shakes \"no\" He unwraps it...",
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

