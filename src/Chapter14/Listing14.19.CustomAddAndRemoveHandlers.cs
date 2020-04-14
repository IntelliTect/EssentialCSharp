namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_19
{
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

        // Define the delegate data type
        public delegate void TemperatureChangeHandler(
            object sender, TemperatureArgs newTemperature);

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

        public float CurrentTemperature
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
        private float _CurrentTemperature;
    }
}