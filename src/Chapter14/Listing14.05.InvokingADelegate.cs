namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_05
{
    using System;

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
                    // temperature by invoking said subcribers
                    OnTemperatureChange?.Invoke(value);     // C# 6.0
                }
            }
        }

        private float _CurrentTemperature;
    }
}