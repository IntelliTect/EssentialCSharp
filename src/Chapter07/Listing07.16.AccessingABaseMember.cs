namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_16
{
    using System;
    using static System.Environment;

    public class Address
    {
        public string StreetAddress;
        public string City;
        public string State;
        public string Zip;

        public override string ToString()
        {
            return $"{ StreetAddress + NewLine }"
                + $"{ City }, { State }  { Zip }";
        }
    }

    public class InternationalAddress : Address
    {
        public string Country;

        public override string ToString()
        {
            return base.ToString() +
                NewLine + Country;
        }
    }
}
