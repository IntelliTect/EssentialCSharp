namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_08;

delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

class Program
{
    private static TemperatureChangedHandler OnTemperatureChanged = delegate { };

    public void Main()
    {

#if(!PreCSharp6)
        OnTemperatureChanged?.Invoke(
            this, new TemperatureEventArgs(value));
#else
        #region INCLUDE
        //...
        TemperatureChangedHandler localOnChange =
            OnTemperatureChanged;
        if(localOnChange is not null)
        {
            // Call subscribers
            localOnChange(
              this, new TemperatureEventArgs(value));
        }
        //...
        #endregion INCLUDE
#endif
    }

    // Justification: Lowercase to simulate the value keyword form a setter.
#pragma warning disable IDE1006 // Naming Styles
    public object? value { get; set; }
#pragma warning restore IDE1006 // Naming Styles
}

public class TemperatureEventArgs
{
    public TemperatureEventArgs(object? _)
    {
        // ...
    }
}
