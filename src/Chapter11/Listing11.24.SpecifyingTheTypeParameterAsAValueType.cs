namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_24
{
    using System;
    using System.Data.SqlTypes;

    public struct Nullable<T> :
        IFormattable, IComparable,
        IComparable<Nullable<T>>, INullable
        where T : struct
    {
        // ...
        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
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