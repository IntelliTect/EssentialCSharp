namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_07;

using System;
using Listing14_01;
using Listing14_05;
public class Program
{
    public static void Main()
    {
        #region INCLUDE
        //...
        Thermostat thermostat = new();
        Heater heater = new(60);
        Cooler cooler = new(80);

        Action<float> delegate1;
        Action<float> delegate2;
        Action<float> delegate3;

        delegate1 = heater.OnTemperatureChanged;
        delegate2 = cooler.OnTemperatureChanged;

        Console.WriteLine("Combine delegates using + operator:");
        #region HIGHLIGHT
        delegate3 = delegate1 + delegate2;
        #endregion HIGHLIGHT
        delegate3(60);

        Console.WriteLine("Uncombine delegates using - operator:");
        #region HIGHLIGHT
        delegate3 = (delegate3 - delegate2)!;
        #endregion HIGHLIGHT
        delegate3(60);
        //...
        #endregion INCLUDE
    }
}
