namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07
{
    using System;

    /*  *****************************************************
     *  For the purposes of pattern matching, assume that the 
     *  source code is not available and so polymorphism is
     *  not possible.
     *  *****************************************************/
    public abstract class Storage
    {
        protected Storage(long capacity)
        {
            Capacity = capacity;
        }
        public long Capacity { get; }
    }
    public class Dvd : Storage
    {
        public Dvd(DvdCapacity capacity) : base((long)capacity) 
        {
            switch (capacity)
            {
                case DvdCapacity.SingleLayeredCapacity:
                case DvdCapacity.DualLayeredCapacity:
                        break;
                default:
                    throw new ArgumentException("Only values of 4.7 GB and 8.5 GB are supported.");
            };
        }
        public bool IsInserted { get; set; }

        internal void Eject()
        {
            Console.WriteLine("Ejecting the DVD...");
        }
        public enum DvdCapacity : long
        {
            SingleLayeredCapacity = 47000000000,
            DualLayeredCapacity = 85000000000
        }
    }
    public class HardDrive : Storage
    {
        public HardDrive(long capacity) : base(capacity) { }
    }
    public class FloppyDrive : Storage 
    {
        public FloppyDrive(): base(1440000){}
    }
    public class UsbKey : Storage
    {
        public UsbKey(long capacity) : base(capacity) { }
        public bool IsPluggedIn { get; set; }

        internal void Unload()
        {
            Console.WriteLine("Unloading the UsbKey...");
        }
    }
}