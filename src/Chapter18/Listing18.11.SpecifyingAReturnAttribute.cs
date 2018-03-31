// NOTE: This file is intentionally set to not compile as part of the project
// because we don't have reference for the DescriptionAttribute.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_11
{
    public class Program
    {
        [return: Description(
           "Returns true if the object is in a valid state.")]
        public bool IsValid()
        {
            // ...
            return true;
        }
    }
}