namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07
{
    delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

    class Program
    {
        private static TemperatureChangedHandler OnTemperatureChanged;

        public void Main()
        {
            // Not thread-safe
            if(OnTemperatureChanged != null)
            {
                // Call subscribers
                OnTemperatureChanged(
                    this, new TemperatureEventArgs(value));
            }
        }

        public object value { get; set; }
    }

    class TemperatureEventArgs
    {
        public TemperatureEventArgs(object value)
        {
            // ...
        }
    }
}
