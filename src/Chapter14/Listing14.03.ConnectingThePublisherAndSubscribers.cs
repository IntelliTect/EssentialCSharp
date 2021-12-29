﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_03
{
    using System;
    using Listing14_01;
    using Listing14_02;

    public class Program
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);
            string? temperature;

            // Using C# 2.0 or later syntax
            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;
            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;

            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            if (!int.TryParse(temperature, out int currentTemperature))
            {
                Console.WriteLine($"'{temperature}' is not a valid integer.");
                return;
            }
            thermostat.CurrentTemperature = currentTemperature;
        }
    }
}