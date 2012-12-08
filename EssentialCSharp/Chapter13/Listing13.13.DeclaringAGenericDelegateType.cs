namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_13
{
    using System;

    public class Thermostat
    {
        public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e)
            where TEventArgs : EventArgs;
    }
}