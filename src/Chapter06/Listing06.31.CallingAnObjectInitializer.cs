namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_31;

using System.Collections.Generic;
using Listing06_28;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        List<Employee> employees = new()
            {
                new("Inigo", "Montoya"),
                new("Kevin", "Bost")
            };
        // ...
    }
}
#endregion INCLUDE
