namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07
{
    using System;

    /*  *****************************************************
     *  For the purposes of pattern matching, assume that the 
     *  source code is not available and so polymorphism is
     *  not possible.
     *  *****************************************************/
    public abstract class Storage { }
    public class Dvd : Storage
    {
        public bool IsInserted { get; set; }

        internal void Eject()
        {
            Console.WriteLine("Ejecting the DVD...");
        }

    }
    public class HardDrive : Storage { }
    public class FloppyDrive : Storage { }
    public class UsbKey : Storage
    {
        public bool IsPluggedIn { get; set; }

        internal void Unload()
        {
            Console.WriteLine("Unloading the UsbKey...");
        }
    }
}