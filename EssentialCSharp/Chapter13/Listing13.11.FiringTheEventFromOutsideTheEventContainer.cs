namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_11
{
    using Listing13_01;
    using Listing13_09;

    public class Program
    {
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);

            // Note: Use new Action(
            //       cooler.OnTemperatureChanged) if C# 1.0.
            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;

            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;

            // Bug: Should not be allowed
            thermostat.OnTemperatureChange(42);
        }
    }
}