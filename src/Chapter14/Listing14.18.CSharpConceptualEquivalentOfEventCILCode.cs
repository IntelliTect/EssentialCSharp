namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_18
{
    using System;
// In an actual implementation _OnTemperatureChange would be used
#pragma warning disable CS0649

    public class Thermostat
    {
        // ...
        // Declaring the delegate field to save the 
        // list of subscribers
        private EventHandler<TemperatureArgs> _OnTemperatureChange;

        public void add_OnTemperatureChange(
            EventHandler<TemperatureArgs> handler)
        {
            System.Delegate.Combine(_OnTemperatureChange, handler);
        }

        public void remove_OnTemperatureChange(
            EventHandler<TemperatureArgs> handler)
        {
            System.Delegate.Remove(_OnTemperatureChange, handler);
        }

        //public event EventHandler<TemperatureArgs> OnTemperatureChange
        //{
        //    //Would cause a compiler error
        //    add
        //    {
        //        add_OnTemperatureChange(value);
        //    }
        //    //Would cause a compiler error
        //    remove
        //    {
        //        remove_OnTemperatureChange(value);
        //    }
        //}

        public class TemperatureArgs : System.EventArgs
        {
            public TemperatureArgs(float newTemperature)
            {
            }

        }
    }
#pragma warning restore CS0649
}