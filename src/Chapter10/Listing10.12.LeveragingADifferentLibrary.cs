namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_12
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.CommandLineUtils;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            CommandLineApplication commandLineApplication =
                new CommandLineApplication(throwOnUnexpectedArg: false);
            CommandArgument name = commandLineApplication.Argument(
                "name", "Enter the full name of the person to be greeted.");
            CommandOption greeting = commandLineApplication.Option(
              "-$|-g |--greeting <greeting>",
              "The greeting to display. The greeting supports"
              + " a format string where '{name}' will be "
              + "substituted with the name.",
              CommandOptionType.SingleValue);
            commandLineApplication.HelpOption("-? | -h | --help");
            //commandLineApplication.OnExecute(() =>
            //{
            //    if (!greeting.HasValue())
            //    {
            //        Console.WriteLine($"Hello { name.Value }.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(
            //            greeting.Value().Replace("{name}", name.Value));
            //    }
            //    return 0;
            //});
            commandLineApplication.Execute(args);

            if (!greeting.HasValue())
            {
                Console.WriteLine($"Hello { name.Value }.");
            }
            else
            {
                Console.WriteLine(
                    greeting.Value().Replace("{name}", name.Value));
            }
        }
    }
}