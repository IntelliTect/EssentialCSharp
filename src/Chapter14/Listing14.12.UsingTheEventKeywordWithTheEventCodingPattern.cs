namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_12;

using System;
#pragma warning disable 67 // OnTemperatureChange is declared but never used
#region INCLUDE
public class Thermostat
{
    #region HIGHLIGHT
    public class TemperatureArgs : System.EventArgs
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature { get; set; }
    }

    // Define the event publisher
    public event EventHandler<TemperatureArgs> OnTemperatureChange =
        delegate { };
    #endregion HIGHLIGHT

    public float CurrentTemperature
    #region EXCLUDE
    {
        get { return _CurrentTemperature; }
        set { _CurrentTemperature = value; }
    }
    #endregion EXCLUDE
    private float _CurrentTemperature;
}
#endregion INCLUDE
#pragma warning restore 67
