namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_24
{
    using System;

#pragma warning disable CA1036 // Operator implementations are discussed in another section of the text

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

#pragma warning restore CA1036 // Operator implementations are discussed in another section of the text
}
