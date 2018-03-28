using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24
{
    public class Program
    {
        static public void Eject(Storage storage)
        {
            switch (storage)
            {
                case null: // The location of case null doesn't matter
                    throw new ArgumentNullException(nameof(storage));
                // ** Causes compile error because case statments below
                // ** are unreachable
                // case Storage tempStorage:
                //    throw new Exception();
                //    break;
                case UsbKey usbKey when usbKey.IsPluggedIn:
                    usbKey.Unload();
                    Console.WriteLine("USB Drive Unloaded!");
                    break;
                case Dvd dvd when dvd.IsInserted:
                    dvd.Eject();
                    Console.WriteLine("DVD Ejected!");
                    break;
                case Dvd dvd when !dvd.IsInserted:
                    throw new ArgumentException("There was no DVD present.");
                case HardDrive hardDrive:
                    throw new InvalidOperationException();
                default:   // The location of case default doesn't matter
                    throw new ArgumentException(nameof(storage));
            }
        }
    }
}
