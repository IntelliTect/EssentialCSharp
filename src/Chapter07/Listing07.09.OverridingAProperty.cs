// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Disabled pending constructor
        
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_09
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
                // Error handling not shown
                FirstName = names[0];
                LastName = names[1];
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // ...
    }
}
