namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_02
{
    using System;

    public class Thermostat
    {
        // Using C# 3.0 or later syntax.
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
                }
            }
        }
        private float _CurrentTemperature;
    }
}