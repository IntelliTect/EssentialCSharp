using System;
using System.Collections.Generic;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_09
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
