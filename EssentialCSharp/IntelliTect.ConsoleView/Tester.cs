using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntelliTect.ConsoleView
{
    public static class Tester
    {

        /// <summary>
        /// Performs a unit test on a console-based method. A "view" of
        /// what a user would see in their console is provided as a string,
        /// where their input (including line-breaks) is surrounded by double
        /// less-than/greater-than signs, like so: "Input please: &lt;&lt;Input&gt;&gt;"
        /// </summary>
        /// <param name="view">Expected "view" to be seen on the console,
        /// including both input and output</param>
        /// <param name="action">Method to be run</param>
        public static void Test(string view, Action action)
        {

            string[] data = Parse(view);

            string input = data[0];
            string output = data[1];

            if(input.Trim().Length == 0)
                Execute(output, action);
            else
                Execute(input, output, action);
        }

        /// <summary>
        /// Executes the unit test while providing console input.
        /// </summary>
        /// <param name="givenInput">Input which will be given</param>
        /// <param name="expectedOutput">The expected output</param>
        /// <param name="action">Action to be tested</param>
        private static void Execute(string givenInput, string expectedOutput, Action action)
        {
            using(TextWriter writer = new StringWriter())
            using(TextReader reader = new StringReader(givenInput))
            {
                System.Console.SetOut(writer);
                System.Console.SetIn(reader);

                action();

                Assert.AreEqual(expectedOutput.Trim(), writer.ToString().Trim());
            }
        }

        /// <summary>
        /// Executes the unit test without providing any console input.
        /// </summary>
        /// <param name="expectedOutput">The expected output</param>
        /// <param name="action">Action to be tested</param>
        private static void Execute(string expectedOutput, Action action)
        {
            using(TextWriter writer = new StringWriter())
            {
                System.Console.SetOut(writer);
                action();

                Assert.AreEqual(expectedOutput.Trim(), writer.ToString().Trim());
            }
        }

        /// <summary>
        /// This parses a "view" string into two separate strings, one
        /// representing virtual input and the other as expected output
        /// </summary>
        /// <param name="view">
        /// What a user would see in the console, but with input/output tokens.
        /// </param>
        /// <returns>[0] Input, and [1] Output</returns>
        private static string[] Parse(string view)
        {
            // Note: This could definitely be optimized, wanted to try it for experience. RegEx perhaps?
            bool isInput = false;
            char[] viewTemp = view.ToCharArray();

            string input = "";
            string output = "";

            // using the char array, categorize each entry as belonging to "input" or "output"
            for(int i = 0; i < viewTemp.Length; i++)
            {
                if(i != viewTemp.Length - 1)
                {
                    // find "<<" tokens which indicate beginning of input
                    if(viewTemp[i] == '<' && viewTemp[i + 1] == '<')
                    {
                        i++;    // skip the other character in token
                        isInput = true;
                        continue;
                    }
                    // find ">>" tokens which indicate end of input
                    else if(viewTemp[i] == '>' && viewTemp[i + 1] == '>')
                    {
                        i++;    // skip the other character in token
                        isInput = false;
                        continue;
                    }
                }
                if(isInput)
                    input += viewTemp[i].ToString();
                else
                    output += viewTemp[i].ToString();
            }

            return new string[] { input, output };
        }
    }
}