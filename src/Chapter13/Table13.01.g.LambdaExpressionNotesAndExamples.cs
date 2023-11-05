// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 7.
    public static void JumpStatementsToOutOfScopeDestinations()
    {
        #if COMPILEERROR
        //ERROR: Control cannot leave the body of an
        //anonymous method or lambda expression
        string[] args = { "/File", "fileThatMostCertainlyDoesNotExist" };
        Func<string> f;
        switch (args[0])
        {
            case "/File":
                f = () =>
                {
                    if (!File.Exists(args[1]))
                        break;
                    return args[1];
                };
        }
        #endif // COMPILEERROR
    }
}
