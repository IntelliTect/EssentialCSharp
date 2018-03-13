using AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_02;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_08;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_11;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_40
{
    public class Program
    {
        public static void Main()
        {
            // ...

            // Error: Cannot convert type ...
            // Pair<PdaItem> pair = (Pair<PdaItem>)new Pair<Contact>();
            // IPair<PdaItem> duple = (IPair<PdaItem>)new Pair<Contact>();
        }
    }
}