namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_21;
#region INCLUDE
// The using directives allow you to drop the namespace
#region HIGHLIGHT
#endregion HIGHLIGHT
public class Program
{
    public static void Main()
    {
        string firstName = "Forest";

        string lastName = """Gump"""; // Single-line raw string literal.

        string greeting = // Single-line raw string literal with interpolation.

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
                    "description" : "She nods, not much interested. He takes an old candy kiss out of his pocket. Offering it to her:",
                    "quote": {
                        "character": "The MAN",
                        "dialogue": "{{proposal}}"
                     },
                     "description" : "She shakes \"no\" He unwraps it, popping it into his mouth.",
                     "quote": {
                        "character": "The MAN",
                         "dialogue": "{{mamaSaid.Replace("\"", "\\\"")}}"
                      }
                }
                """;

        Console.WriteLine(jsonDialogue);
    }
}
#endregion INCLUDE

