namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_13
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
            set { _CurrentTemperature = value; }
        }
        private float _CurrentTemperature;
    }
}