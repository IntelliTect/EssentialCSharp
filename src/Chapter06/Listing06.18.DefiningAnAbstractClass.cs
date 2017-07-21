namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_18
{
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
}
