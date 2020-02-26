namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_12
{
    using Microsoft.Extensions.Logging;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            using ILoggerFactory loggerFactory =
                LoggerFactory.Create(builder => builder.AddConsole().AddDebug());

            ILogger logger = loggerFactory.CreateLogger(
                categoryName: "Console");

            logger.LogInformation($@"Hospital Emergency Codes: = '{
                string.Join("', '", args)}'");
            // ...

            logger.LogWarning("This is a test of the emergency...");
            // ...
        }
    }
}