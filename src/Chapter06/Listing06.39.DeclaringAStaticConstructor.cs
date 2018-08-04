namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_39
{
    using System;

    class Employee
    {
        static Employee()
        {
            Random randomGenerator = new Random();
            NextId = randomGenerator.Next(101, 999);
        }

        // ...
        public static int NextId = 42;
        // ...
    }
}