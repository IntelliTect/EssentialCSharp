namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_14
{
    using System;

    public class Thermostat
    {
        public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e)
            where TEventArgs : EventArgs;
    }
}