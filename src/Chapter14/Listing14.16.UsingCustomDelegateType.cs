namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_16
{
    #region INCLUDE
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

        #region HIGHLIGHT
        public delegate void TemperatureChangeHandler(
            object sender, TemperatureArgs newTemperature);

        public event TemperatureChangeHandler?
            OnTemperatureChange;
        #endregion HIGHLIGHT

        public float CurrentTemperature
        #region EXCLUDE
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
                    // Call subscribers
                    OnTemperatureChange?.Invoke(
                      this, new TemperatureArgs(value));
                }
            }
        }
        #endregion EXCLUDE
        private float _CurrentTemperature;
    }
    #endregion INCLUDE
}