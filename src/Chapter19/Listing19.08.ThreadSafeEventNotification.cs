namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_08
{
    delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

    class Program
    {
        private static TemperatureChangedHandler OnTemperatureChanged;

        public void Main()
        {

#if(!PreCSharp6)
            OnTemperatureChanged?.Invoke(
                this, new TemperatureEventArgs(value));
#else
            TemperatureChangedHandler localOnChange =
                OnTemperatureChanged;
            if(localOnChange != null)
            {
                // Call subscribers
                localOnChange(
                  this, new TemperatureEventArgs(value));
            }
#endif
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
