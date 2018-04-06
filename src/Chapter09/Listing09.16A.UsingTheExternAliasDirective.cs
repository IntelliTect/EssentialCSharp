namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_16A
{
    // extern must precede all other namespace elements 
    /* extern alias CoordPlus; --> not actually referencing anything, so commented out */

    /* using System;
    using CoordPlus::AddisonWesley.Michaelis.EssentialCSharp; */
    // Equivalent also allowed
    // using CoordPlus.AddisonWesley.Michaelis.EssentialCSharp;

    /* using global::AddisonWesley.Michaelis.EssentialCSharp; */
    // Equivalent NOT allowed
    // using global.AddisonWesley.Michaelis.EssentialCSharp;

    public class Program
    {
        // ...
    }
}