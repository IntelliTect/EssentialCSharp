namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_10
{
    using System;
    using System.Collections.Generic;
    using Listing14_01;

    public class Thermostat
    {
        // Using C# 3.0 or later syntax
        // Define the event publisher
        public Action<float> OnTemperatureChange;

        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if(value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    Action<float> onTemperatureChange = OnTemperatureChange;
                    if (onTemperatureChange != null)
                    {
                        List<Exception> exceptionCollection =
                            new List<Exception>();
                        foreach(
                            Action<float> handler in
                            onTemperatureChange.GetInvocationList())
                        {
                            try
                            {
                                handler(value);
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
                    }
                }
            }
        }
        private float _CurrentTemperature;
    }

    public class Program
    {
        public static void Main()
        {
            try
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
            catch(AggregateException exception)
            {
                Console.WriteLine(exception.Message);
                foreach(Exception item in exception.InnerExceptions)
                {
                    Console.WriteLine("\t{0}: {1}",
                        item.GetType(), item.Message);
                }
            }
        }
    }
}