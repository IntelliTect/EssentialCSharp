﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_16
{
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

        public delegate void TemperatureChangeHandler(
            object sender, TemperatureArgs newTemperature);

        public event TemperatureChangeHandler
            OnTemperatureChange;

        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if(value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    // If there are any subscribers
                    // then notify them of changes in 
                    // temperature
                    if(OnTemperatureChange != null)
                    {
                        // Call subscribers
                        OnTemperatureChange(
                          this, new TemperatureArgs(value));
                    }
                }
            }
        }
        private float _CurrentTemperature;
    }
}