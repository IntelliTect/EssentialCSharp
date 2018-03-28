namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_17
{
    public class PdaItem
    {
        public PdaItem(string name)
        {
            Name = name;
        }

        // ...
        public string Name { get; set; }
    }
    public class Contact : PdaItem
    {
        public Contact(string name) :
            base(name)
        {
            Name = name;
        }

        public new string Name { get; set; }
        // ...
    }
}
