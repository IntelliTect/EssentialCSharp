namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_15
{
// With a concrete implementation we could use our PdaItem object
#pragma warning disable CS0168
    public abstract class PdaItem
    {
        public PdaItem(string name)
        {
            Name = name;
        }

        public virtual string Name { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            PdaItem item;
            // ERROR:  Cannot create an instance of the abstract class
            //item = new PdaItem("Inigo Montoya"); //uncomment this line and it will not compile
        }
    }
#pragma warning restore CS0168
}
