namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_16
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

            public float NewTemperature
            {
                get { return _newTemperature; }
                set { _newTemperature = value; }
            }
            private float _newTemperature;
        }

        public event EventHandler<TemperatureArgs> OnTemperatureChange;
    }
}