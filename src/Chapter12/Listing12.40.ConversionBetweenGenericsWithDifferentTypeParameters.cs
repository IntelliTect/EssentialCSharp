using AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_02;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_08;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_11;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_40
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
