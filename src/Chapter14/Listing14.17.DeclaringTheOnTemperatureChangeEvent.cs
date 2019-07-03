namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_17
{
    using System;
// In an actual implementation we would utilize this event
#pragma warning disable CS0067

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
#pragma warning restore CS0067
}