namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_13;

using System;

public class Thermostat
{
    #region INCLUDE
    public delegate void EventHandler<TEventArgs>(
        object sender, TEventArgs e)
        where TEventArgs : EventArgs;
    #endregion INCLUDE
}
