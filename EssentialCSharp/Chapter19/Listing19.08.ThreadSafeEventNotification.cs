namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_08
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

    class Program
    {
        private static TemperatureChangedHandler OnTemperatureChanged;
        
        public void Main()
        {
            TemperatureChangedHandler localOnChange =
                OnTemperatureChanged;
            if (localOnChange != null)
            {
                // Call subscribers
                localOnChange(
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
