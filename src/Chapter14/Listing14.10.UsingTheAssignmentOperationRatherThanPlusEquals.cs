using AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_10;

using System;
using Listing14_01;
#region INCLUDE
public class Program
{
    public static void Main()
    {
        Thermostat thermostat = new();
        Heater heater = new(60);
        Cooler cooler = new(80);

        thermostat.OnTemperatureChange =
            heater.OnTemperatureChanged;

        // Bug: Assignment operator overrides 
        // previous assignment
        #region HIGHLIGHT
        thermostat.OnTemperatureChange = 
            cooler.OnTemperatureChanged;
        #endregion HIGHLIGHT

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
#endregion INCLUDE
