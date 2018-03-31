namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04
{
    using System;
    using Listing14_01;

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
            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;

            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
        }
    }
}