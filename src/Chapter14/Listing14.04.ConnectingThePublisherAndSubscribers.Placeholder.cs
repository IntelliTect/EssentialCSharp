namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04;

using System;
using Listing14_01;

public class Program
{
    public static void Main()
    {
        Thermostat thermostat = new();
        Heater heater = new(60);
        Cooler cooler = new(80);

        thermostat.OnTemperatureChange +=
            heater.OnTemperatureChanged;
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