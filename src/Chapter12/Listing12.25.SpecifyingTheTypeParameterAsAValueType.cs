namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_24
{
    using System;

    public struct Nullable<T> :
        IFormattable, IComparable,
        IComparable<Nullable<T>>, INullable
        where T : struct
    {
        // ...
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Nullable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsNull
        {
            get { throw new NotImplementedException(); }
        }
    }

}
