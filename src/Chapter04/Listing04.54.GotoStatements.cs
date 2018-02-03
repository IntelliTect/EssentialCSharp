namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_52
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isOutputSet = false;
            bool isFiltered = false;
            bool isRecursive = false;

            foreach(string option in args)
            {
                switch(option)
                {
                    case "/out":
                        isOutputSet = true;
                        isFiltered = false;
                        goto default;
                    case "/f":
                        isFiltered = true;
                        isRecursive = false;
                        goto default;
                    default:
                        if(isRecursive)
                        {
                            // Recurse down the hierarchy
                            // ...
                        }
                        else if(isFiltered)
                        {
                            // Add option to list of filters.
                            // ...
                        }
                        break;
                }

            }

            // ...

        }
    }
}
