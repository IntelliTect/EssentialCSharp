namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_19
{
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

    public static class ByteArrayDataSource
    {
        static private byte[] LoadData()
        {
            // Imagine a much lager number
            byte[] data = new byte[1000];
            // Load data
            // ...
            return data;
        }

        static private WeakReference<byte[]>? Data { get; set; }

        static public byte[] GetData()
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
                // Reload the data and save it before
                // returning it.
                target = LoadData();
                Data.SetTarget(target);
                return target;
            }
        }
    }


    public class ObjectDataSource
    {
        private readonly WeakReference Data = new WeakReference(null);
        public void ClearReference()
        {
            Data.Target = null;
        }

        public byte[] GetData()
        {
            byte[]? data = (byte[]?)Data.Target;

            if (data is object)
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

}