using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_14
{
    public class PdaItem
    {
        public PdaItem(string name)
        {
            Name = name;
        }

        // ...

        public virtual string Name { get; set; }
    }
    public class Contact : PdaItem
    {
        // Disable warning since FirstName&LastName set via Name property 
        #pragma warning disable CS8618 // Non-nullable field is uninitialized. 
        public Contact(string name) :
            base(name)
        {
        }
        #pragma warning restore CS8618

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

        [NotNull] [DisallowNull]
        public string FirstName { get; set; }
        [NotNull] [DisallowNull]
        public string LastName { get; set; }

        // ...
    }
}
