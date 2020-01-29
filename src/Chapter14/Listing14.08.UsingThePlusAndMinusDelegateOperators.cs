namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_08
{
    using System;
    using Listing14_01;
    using Listing14_05;

    public class Program
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);

            Action<float> delegate1;
            Action<float> delegate2;
            Action<float> delegate3;

            // Note: Use new Action(cooler.OnTemperatureChanged)
            // for C# 1.0 syntax
            delegate1 = heater.OnTemperatureChanged;
            delegate2 = cooler.OnTemperatureChanged;

            Console.WriteLine("Combine delegates using + operator:");
            delegate3 = delegate1 + delegate2;
            delegate3(60);

            Console.WriteLine("Uncombine delegates using - operator:");
            delegate3 = (delegate3 - delegate2)!;
            delegate3(60);
        }
    }
}