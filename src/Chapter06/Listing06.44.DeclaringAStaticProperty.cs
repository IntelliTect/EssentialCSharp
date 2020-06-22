namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_44
{
    class Employee
    {
        // ...
        public static int NextId
        {
            get
            {
                return _NextId;
            }
            private set
            {
                _NextId = value;
            }
        }
        public static int _NextId = 42;
        // ...
    }
}
