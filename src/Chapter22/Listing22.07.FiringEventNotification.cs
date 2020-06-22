namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_07
{
    delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

    class Program
    {
        private static readonly TemperatureChangedHandler OnTemperatureChanged = delegate { };

        public void Main()
        {
            // Not thread safe
            if(OnTemperatureChanged != null) // Warning ignored to demonstrate problem.
            {
                // Call subscribers
                OnTemperatureChanged(
                    this, new TemperatureEventArgs(value));
            }
        }

        // Justification: Lowercase to simulate the value keyword form a stetter.
        #pragma warning disable IDE1006 // Naming Styles
        public object? value { get; set; }
        #pragma warning restore IDE1006 // Naming Styles
    }

    class TemperatureEventArgs
    {
        public TemperatureEventArgs(object? _)
        {
            // ...
        }
    }
}
