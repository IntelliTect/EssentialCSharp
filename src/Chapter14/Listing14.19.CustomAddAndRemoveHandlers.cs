namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_19
{
    #region INCLUDE
    public class Thermostat
    {
        public class TemperatureArgs : System.EventArgs
        #region EXCLUDE
        {
            public TemperatureArgs(float newTemperature)
            {
                NewTemperature = newTemperature;
            }

            public float NewTemperature { get; set; }
        }
     
        // Define the delegate data type
        public delegate void TemperatureChangeHandler(
            object sender, TemperatureArgs newTemperature);
        #region EXCLUDE
        #region HIGHLIGHT
        // Define the event publisher
        public event TemperatureChangeHandler OnTemperatureChange
        {
            add
            {
                _OnTemperatureChange = (TemperatureChangeHandler)System.Delegate.Combine(value, _OnTemperatureChange);
            }
            remove
            {
                _OnTemperatureChange = 
                    (TemperatureChangeHandler?)System.Delegate.Remove(_OnTemperatureChange, value);
            }
        }
        protected TemperatureChangeHandler? _OnTemperatureChange;
        #endregion HIGHLIGHT

        public float CurrentTemperature
        #region EXCLUDE
        {
            set
            {
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    // If there are any subscribers,
                    // notify them of changes in 
                    // temperature by invoking said subcribers
                    _OnTemperatureChange?.Invoke( // C# 6.0
                          this, new TemperatureArgs(value));
                }
            }
            get { return _CurrentTemperature; }
        }
        #endregion EXCLUDE
        private float _CurrentTemperature;
    }
    #endregion INCLUDE
}