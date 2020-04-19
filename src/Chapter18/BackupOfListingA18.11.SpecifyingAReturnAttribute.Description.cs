using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_11
{
    public class DescriptionAttribute : Attribute
    {
        private string description;
		public string Description { get { return Description; } }

        public DescriptionAttribute(string description)
        {
            this.description = description;
        }

    }
}
