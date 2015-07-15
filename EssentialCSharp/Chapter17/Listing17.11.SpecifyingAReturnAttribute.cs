namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_09
{
    using System.ComponentModel;

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