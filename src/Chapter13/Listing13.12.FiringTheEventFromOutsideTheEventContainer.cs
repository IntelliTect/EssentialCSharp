namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_12
{
    using Listing13_01;
    using Listing13_10;

    public class Program
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);

            // Note: Use new Action(cooler.OnTemperatureChanged)
            // for C# 1.0 syntax.
            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;

            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;

            // Bug: Should not be allowed
            thermostat.OnTemperatureChange(42);
        }
    }
}