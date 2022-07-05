﻿// TODO: Update listing in Manuscript
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_09
{
    using Listing14_01;
    using Listing14_05;
    using System;

    public class Program
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);

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
            string? temperature = Console.ReadLine();
            if (!int.TryParse(temperature, out int currentTemperature))
            {
                Console.WriteLine($"'{temperature}' is not a valid integer.");
                return;
            }
            thermostat.CurrentTemperature = currentTemperature;
        }
    }
}