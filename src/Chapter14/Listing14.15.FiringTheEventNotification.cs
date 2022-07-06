namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_15
{
    using System;
    #region INCLUDE
    public class Thermostat
    #region EXCLUDE
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
        #endregion EXCLUDE

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
                    #region HIGHLIGHT
                    OnTemperatureChange?.Invoke( // C# 6.0
                          this, new TemperatureArgs(value));
                    #endregion HIGHLIGHT
                }
            }
        }
        private float _CurrentTemperature;
    }
    #endregion INCLUDE
}