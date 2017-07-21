namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_07
{
    using System;
    using Listing13_01;
    using Listing13_05;

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

            // use Constructor syntax for C# 1.0.
            delegate1 = heater.OnTemperatureChanged;
            delegate2 = cooler.OnTemperatureChanged;

            Console.WriteLine("Invoke both delegates:");
            delegate3 = delegate1;
            delegate3 += delegate2;
            delegate3(90);

            Console.WriteLine("Invoke only delegate2");
            delegate3 -= delegate1;
            delegate3(30);
        }
    }
}