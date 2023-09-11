namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_30;

using System.Collections.Generic;
using Listing06_27a;

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
