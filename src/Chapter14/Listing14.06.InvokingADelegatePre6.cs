namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_06
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
                    // If there are any subscribers,
                    // notify them of changes in 
                    // temperature
                    Action<float> localOnChange =
                        OnTemperatureChange;
                    if(localOnChange != null)
                    {
                        // Call subscribers
                        localOnChange(value);
                    }
                }
            }
        }

        private float _CurrentTemperature;
    }
}