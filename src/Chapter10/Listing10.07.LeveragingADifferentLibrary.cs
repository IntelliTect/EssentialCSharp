namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_07;

using Microsoft.Extensions.Logging;

#region INCLUDE
public sealed class Program
{
    public static void Main(string[] args)
    {
        using ILoggerFactory loggerFactory =
            LoggerFactory.Create(builder =>
            builder.AddConsole().AddDebug());

        ILogger logger = loggerFactory.CreateLogger<Program>();

        logger.LogInformation($@"Hospital Emergency Codes: = '{
            string.Join("', '", args)}'");
        // ...

        logger.LogWarning("This is a test of the emergency...");
        // ...
    }
}
#endregion INCLUDE
