namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_48;

using System;

#region INCLUDE
public class Employee
{
    static Employee()
    {
        Random randomGenerator = new();
        NextId = randomGenerator.Next(101, 999);
    }

    // ...
    public static int NextId = 42;
    // ...
}
#endregion INCLUDE
