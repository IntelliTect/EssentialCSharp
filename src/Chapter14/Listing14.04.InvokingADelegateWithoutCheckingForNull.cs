namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04
{
    using System;

    public class Thermostat
    {
        // Define the event publisher
        public Action<float> OnTemperatureChange { get; set; }

        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if(value != CurrentTemperature)
                {
                    _CurrentTemperature = value;

                    // INCOMPLETE:  Check for null needed
                    // Call subscribers
                    OnTemperatureChange(value);
                }
            }
        }
        private float _CurrentTemperature;
    }
}