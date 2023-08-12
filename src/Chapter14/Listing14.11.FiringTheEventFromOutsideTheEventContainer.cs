namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_11;

using Listing14_01;
using Listing14_09;
#region INCLUDE
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

        // Bug: Should not be allowed
        #region HIGHLIGHT
        thermostat.OnTemperatureChange(42);
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
