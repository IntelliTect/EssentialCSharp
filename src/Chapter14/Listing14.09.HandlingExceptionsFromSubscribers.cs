namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_09;

using System;
using System.Collections.Generic;
using Listing14_01;
#region INCLUDE
public class Thermostat
{
    // Define the event publisher
    public Action<float>? OnTemperatureChange;

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            if(value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                Action<float>? onTemperatureChange 
                    = OnTemperatureChange;
                if (onTemperatureChange is not null)
                {
                    #region HIGHLIGHT
                    List<Exception> exceptionCollection =
                        new();
                    foreach(
                        Delegate handler in
                        onTemperatureChange.GetInvocationList())
                    {
                        try
                        {
                            ((Action<float>)handler)(value);
                        }
                        catch(Exception exception)
                        {
                            exceptionCollection.Add(exception);
                        }
                    }
                    if(exceptionCollection.Count > 0)
                    {
                        throw new AggregateException(
                            "There were exceptions thrown by " +
                            "OnTemperatureChange Event subscribers.",
                            exceptionCollection);
                    }
                    #endregion HIGHLIGHT
                }
            }
        }
    }
    private float _CurrentTemperature;
}
#endregion INCLUDE

public class Program
{
    public static void Main()
    {
        try
        {
            Thermostat thermostat = new();
            Heater heater = new(60);
            Cooler cooler = new(80);

            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;
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
        catch(AggregateException exception)
        {
            Console.WriteLine(exception.Message);
            if (exception.InnerExceptions.Count < 1)
            {
                // Enumerate the exceptions only if there is more than
                // one because with one the message gets merged into the 
                // Aggregate exception message.
                foreach (Exception item in exception.InnerExceptions)
                {
                    Console.WriteLine("\t{0}: {1}",
                        item.GetType(), item.Message);
                }
            }
        }
    }
}
