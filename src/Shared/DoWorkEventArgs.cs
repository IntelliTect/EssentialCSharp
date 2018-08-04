using System;
using System.ComponentModel;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public class DoWorkEventArgs : EventArgs
    {
        public DoWorkEventArgs(object argument) { this.Argument = argument; }
        public object Argument { get; }
        public bool Cancel { get; set; }
        public object Result { get; set; }
    }
}
