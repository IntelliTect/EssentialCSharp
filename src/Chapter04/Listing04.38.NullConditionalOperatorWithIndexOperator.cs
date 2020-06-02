// Justification: Intentionally demonstrating legacy syntax.
#pragma warning disable IDE1005 // Delegate invocation can be simplified.
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_38
{
    public class Thermostat
    {
        public event System.EventHandler PropertyChanged = delegate { };

        private int _Temperature;
        public int Temperature
        {
            get { return _Temperature; }
            set 
            {
                System.EventHandler propertyChanged =
                    PropertyChanged;
                if (propertyChanged != null)
                {
                    propertyChanged(this,
                        new System.EventArgs());
                }

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
                    new System.EventArgs());

                _Humidity = value;
            }
        }
    }
}
