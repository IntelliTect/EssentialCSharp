using AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_11
{
    using System;
    using Listing13_01;

    public class Program
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);
            string temperature;

            // Note: Use new Action(
            //       cooler.OnTemperatureChanged) if C# 1.0 
            thermostat.OnTemperatureChange =
                heater.OnTemperatureChanged;

            // Bug:  assignment operator overrides 
            // previous assignment.
            thermostat.OnTemperatureChange = 
                cooler.OnTemperatureChanged;

            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
        }
    }
}