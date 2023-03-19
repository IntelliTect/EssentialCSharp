namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04;

using System;
#region INCLUDE
public class Thermostat
{
    #region EXCLUDE
    // Define the event publisher
    public Action<float>? OnTemperatureChange { get; set; }
    #endregion EXCLUDE
    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            #region HIGHLIGHT
            if (value != CurrentTemperature)
            #endregion HIGHLIGHT
            {
                #region HIGHLIGHT
                _CurrentTemperature = value;
                #endregion HIGHLIGHT

                // Call subscribers
                // Incomplete, check for null needed
                #region EXCLUDE
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                #endregion EXCLUDE
                OnTemperatureChange(value);
                #region EXCLUDE
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                #endregion EXCLUDE
            }
        }
    }
    private float _CurrentTemperature;
}
#endregion INCLUDE
