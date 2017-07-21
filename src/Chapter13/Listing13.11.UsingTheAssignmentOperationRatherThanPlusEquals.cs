﻿using AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_02;

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

            // Note: Use new Action(cooler.OnTemperatureChanged)
            // for C# 1.0 syntax.
            thermostat.OnTemperatureChange =
                heater.OnTemperatureChanged;

            // Bug: Assignment operator overrides 
            // previous assignment.
            thermostat.OnTemperatureChange = 
                cooler.OnTemperatureChanged;

            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
        }
    }
}