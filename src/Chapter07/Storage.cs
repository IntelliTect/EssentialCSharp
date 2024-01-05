namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07;

using System;

/*  *****************************************************
 *  考虑到模式匹配的目的，假定源代码不可用，所以不能利用多态性。
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
                throw new ArgumentException("只支持4.7 GB和8.5 GB。");
        };
    }
    public bool IsInserted { get; set; }

    internal static void Eject()
    {
        Console.WriteLine("正在弹出DVD光盘...");
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

    internal static void Unload()
    {
        Console.WriteLine("卸载UsbKey...");
    }
}