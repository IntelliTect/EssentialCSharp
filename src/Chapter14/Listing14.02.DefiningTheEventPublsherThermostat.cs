namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_02;

using System;
#region INCLUDE
public class Thermostat
{
    // Define the event publisher (initially without the sender)
    public Action<float>? OnTemperatureChange { get; set; }

    public float CurrentTemperature { get; set; }
    #endregion INCLUDE
}