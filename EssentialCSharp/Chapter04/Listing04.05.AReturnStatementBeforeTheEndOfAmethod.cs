namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_05
{
    public class Program
    {
        static bool MyMethod()
        {
            string command = ObtainCommand();

            switch (command)
            {
                case "quit":
                    return false;
                // ... omitted, other cases
                default:
                    return true;
            }
        }

        private static string ObtainCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}
