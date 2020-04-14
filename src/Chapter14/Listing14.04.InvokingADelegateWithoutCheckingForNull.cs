namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04
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

                    // Call subscribers
                    // Justification: Incomplete, check for null needed.
                    #pragma warning disable CS8602 // Dereference of a possibly null reference.
                    OnTemperatureChange(value);
                    #pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
        private float _CurrentTemperature;
    }
}