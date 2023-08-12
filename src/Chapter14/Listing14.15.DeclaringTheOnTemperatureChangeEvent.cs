// This is pseudo code to represent the generated IL so guidelines not followed.
#pragma warning disable CS0067 // The event is never used
#pragma warning disable CS0469 // Field is never assigned to, and will always have its default value - null

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_15;

using System;
// In an actual implementation we would utilize this event
#region INCLUDE
public class Thermostat
#region EXCLUDE
{
    public class TemperatureArgs : System.EventArgs
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature { get; set; }
    }
    #endregion EXCLUDE
    public event EventHandler<TemperatureArgs>? OnTemperatureChange;
}
#endregion INCLUDE
