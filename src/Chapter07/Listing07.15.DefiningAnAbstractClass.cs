namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_15
{
    // With a concrete implementation we could use our PdaItem object
#pragma warning disable CS0168
    #region INCLUDE
    // Define an abstract class
    #region HIGHLIGHT
    public abstract class PdaItem
    #endregion HIGHLIGHT
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
            // item = new PdaItem("Inigo Montoya");
        }
    }
    #endregion INCLUDE
#pragma warning restore CS0168
}
