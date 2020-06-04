// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Disabled pending constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_13
{
    using static System.Environment;

    public class Address
    {
        //public Address(string streetAddress, string city,
        //    string state, string zip)
        //{
        //    StreetAddress = streetAddress;
        //    City = city;
        //    State = state;
        //    Zip = zip;
        //}

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
