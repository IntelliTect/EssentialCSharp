namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_07;

delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

public class Program
{
    private static readonly TemperatureChangedHandler OnTemperatureChanged = delegate { };

    public void Main()
    {
        #region INCLUDE
        // Not thread safe
        #region HIGHLIGHT
        if (OnTemperatureChanged is not null)
        #endregion HIGHLIGHT
        {
            // Call subscribers
            OnTemperatureChanged(
                this, new TemperatureEventArgs(value));
        }
        #endregion INCLUDE
    }

    // Justification: Lowercase to simulate the value keyword from a setter.
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
