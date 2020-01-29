namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_15
{
    using System;

    public class Thermostat
    {
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
                    OnTemperatureChange?.Invoke( // C# 6.0
                          this, new TemperatureArgs(value));
                }
            }
        }
        private float _CurrentTemperature;
    }
}