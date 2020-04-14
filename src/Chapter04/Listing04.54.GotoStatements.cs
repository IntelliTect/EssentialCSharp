#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_54
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
                            // Add option to list of filters
                            // ...
                        }
                        break;
                }

            }

            // ...

        }
    }
}
