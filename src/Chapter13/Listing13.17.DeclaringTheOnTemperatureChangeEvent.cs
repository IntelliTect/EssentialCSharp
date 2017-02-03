namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_17
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
                get { return _NewTemperature; }
                set { _NewTemperature = value; }
            }
            private float _NewTemperature;
        }

        public event EventHandler<TemperatureArgs> OnTemperatureChange;
    }
}