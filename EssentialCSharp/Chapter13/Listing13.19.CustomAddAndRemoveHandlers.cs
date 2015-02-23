namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_19
{
    public class Thermostat
    {
        public class TemperatureArgs : System.EventArgs
        {
            // ...
        }

        // Define the delegate data type
        public delegate void TemperatureChangeHandler(
            object sender, TemperatureArgs newTemperature);

        // Define the event publisher
        public event TemperatureChangeHandler OnTemperatureChange
        {
            add
            {
                System.Delegate.Combine(value, _OnTemperatureChange);
            }
            remove
            {
                System.Delegate.Remove(_OnTemperatureChange, value);
            }
        }
        protected TemperatureChangeHandler _OnTemperatureChange;

        public float CurrentTemperature
        {
            // ...
            get { return _CurrentTemperature; }
        }
        private float _CurrentTemperature;
    }
}