namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_16
{
    using System;

    public class Address
    {
        public string StreetAddress;
        public string City;
        public string State;
        public string Zip;

        public override string ToString()
        {
            return string.Format("{0}" + Environment.NewLine +
                "{1}, {2}  {3}",
                StreetAddress, City, State, Zip);
        }
    }

    public class InternationalAddress : Address
    {
        public string Country;

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                Country;
        }
    }
}
