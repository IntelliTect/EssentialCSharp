namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_05;

using System;
#region INCLUDE
public class Thermostat
{
    // Define the event publisher
    public Action<float>? OnTemperatureChange { get; set; }

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            if(value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                // If there are any subscribers,
                // notify them of changes in 
                // temperature by invoking said subscribers
                #region HIGHLIGHT
                OnTemperatureChange?.Invoke(value);     // C# 6.0
                #endregion HIGHLIGHT
            }
        }
    }

    private float _CurrentTemperature;
}
#endregion INCLUDE
