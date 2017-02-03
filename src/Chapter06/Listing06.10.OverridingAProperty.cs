namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_10
{
    public class PdaItem
    {
        public virtual string Name { get; set; }
        // ...
    }

    public class Contact : PdaItem
    {
        public override string Name
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }

            set
            {
                string[] names = value.Split(' ');
                // Error handling not shown.
                FirstName = names[0];
                LastName = names[1];
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // ...
    }
}
