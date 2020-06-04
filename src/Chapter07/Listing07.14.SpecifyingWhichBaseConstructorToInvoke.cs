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
        public Contact(string name)
            : base(name)
        {
        }

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
        public string? FirstName { get; set; }
        [NotNull] [DisallowNull]
        public string? LastName { get; set; }

        // ...
    }
}
