// Justification: Intentionally demonstrating legacy syntax.
#pragma warning disable IDE1005 // Delegate invocation can be simplified.
using System.ComponentModel;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_39;

public class Thermostat
{
    public event EventHandler PropertyChanged = delegate { };

    private int _Temperature;
    public int Temperature
    {
        get { return _Temperature; }
        set 
        {
            #region INCLUDE
            EventHandler propertyChanged =
                PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this,
                    new EventArgs());
            }
            #endregion INCLUDE

            _Temperature = value; 
        }
    }

    int _Humidity;
    public int Humidity
    {
        get { return _Humidity; }
        set
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(nameof(Humidity)));

            _Humidity = value;
        }
    }
}
