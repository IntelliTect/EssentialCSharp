namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_24;

using System;
#region INCLUDE
public struct Nullable<T> :
    IFormattable, IComparable,
    IComparable<Nullable<T>>, INullable
    #region HIGHLIGHT
    where T : struct
    #endregion HIGHLIGHT
{
    // ...
    public static implicit operator Nullable<T>(T value) => new(value);
    public static explicit operator T(Nullable<T> value) => value!.Value;
    #region EXCLUDE
    public Nullable(T value)
    {
        // ...
    }
    public T Value => throw new NotImplementedException();
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
    #endregion EXCLUDE
}
#endregion INCLUDE
