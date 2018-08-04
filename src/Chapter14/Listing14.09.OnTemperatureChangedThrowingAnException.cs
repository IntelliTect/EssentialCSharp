namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_09
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
            string temperature;

            // Using C# 2.0 or later syntax
            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;
            // Using C# 3.0.  Change to anonymous method
            // if using C# 2.0
            thermostat.OnTemperatureChange +=
                (newTemperature) =>
                    {
                        throw new InvalidOperationException();
                    };
            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;

            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
        }
    }
}