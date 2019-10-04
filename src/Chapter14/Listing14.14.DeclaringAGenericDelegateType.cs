namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_14
{
    using System;

#pragma warning disable CA1003 // This is a basic example of an EventHandler

    public class Thermostat
    {
        public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e)
            where TEventArgs : EventArgs;
    }

#pragma warning restore CA1003
}