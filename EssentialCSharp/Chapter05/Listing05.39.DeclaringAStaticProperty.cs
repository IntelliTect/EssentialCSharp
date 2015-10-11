namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_39
{
    class Employee
    {
        // ...
        
        public static int NextId { get; private set; } = 42;
        // ...
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_39_PreCSharp6
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
