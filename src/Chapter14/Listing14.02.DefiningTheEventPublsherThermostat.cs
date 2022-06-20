namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_02
{
    using System;
    #region INCLUDE
    public class Thermostat
    {
        // Using C# 3.0 or later syntax.
        // Define the event publisher (initially without the sender)
        public Action<float>? OnTemperatureChange { get; set; }

        public float CurrentTemperature
        #endregion INCLUDE
        {
            get { return _CurrentTemperature; }
            set
            {
                if(value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                }
            }
        }
        private float _CurrentTemperature;
    }
}