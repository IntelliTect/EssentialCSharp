namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_39
{
    using System;

#pragma warning disable CA1810 // Implementation is incomplete

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

#pragma warning restore CA1810 // Implementation is incomplete
}