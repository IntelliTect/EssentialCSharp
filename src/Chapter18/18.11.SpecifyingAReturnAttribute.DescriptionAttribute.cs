using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_11
{
    public class DescriptionAttribute : Attribute
    {
        // TODO: Update listing in Manuscript
        private readonly string _Description;
		public string Description { get { return _Description; } }

        public DescriptionAttribute(string description)
        {
            this._Description = description;
        }

    }
}
