namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_14;

using System;

public class LazyWeakReference<T>
    where T: class
{
    private Lazy<WeakReference<T>> WeakReference { get; }
    private Func<T> ValueFactory { get;  }
    public LazyWeakReference(Func<T> valueFactory)
    {
        WeakReference = 
            new Lazy<WeakReference<T>>(() => new WeakReference<T>(valueFactory()));
        ValueFactory = valueFactory;
    }

    public T Target
    {
        get
        {
            T value;
            if(WeakReference.Value.TryGetTarget(out T? target))
            {
                value = target;
            }
            else
            {
                value = ValueFactory();
                WeakReference.Value.SetTarget(value);
            }
            return value;
        }
    }
}

#region INCLUDE
public static class ByteArrayDataSource
{
    private static byte[] LoadData()
    {
        // Imagine a much lager number
        byte[] data = new byte[1000];
        // Load data
        // ...
        return data;
    }

    private static WeakReference<byte[]>? Data { get; set; }

    public static byte[] GetData()
    {
        byte[]? target;
        if (Data is null)
        {
            target = LoadData();
            Data = new WeakReference<byte[]>(target);
            return target;
        }
        else if (Data.TryGetTarget(out target))
        {
            return target;
        }
        else
        {
            // Reload the data and assign it (creating a strong
            // reference) before setting WeakReference's Target
            // and returning it.
            target = LoadData();
            Data.SetTarget(target);
            return target;
        }
    }
}

// ...
#endregion INCLUDE

public class ObjectDataSource
{
    private readonly WeakReference Data = new(null);
    public void ClearReference()
    {
        Data.Target = null;
    }

    public byte[] GetData()
    {
        byte[]? data = (byte[]?)Data.Target;

        if (data is not null)
        {
            return data;
        }
        else
        {
            // Imagine a much lager number
            data = new byte[1000];

            // Load data
            // ...

            // Create a weak reference
            // to data for use later
            Data.Target = data;
        }
        return data;
    }
}
