using System;
using System.Collections.Generic;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_20;

public class Foo : IEquatable<Foo>
{
    public int Number { get; init; }
    public string Name { get; init; }

    public Foo(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public Foo()
    {
        Number = 0;
        Name = string.Empty;
    }

    #region INCLUDE
    public override bool Equals(object? obj)
    {
        return Equals(obj as Foo);
    }
    #endregion INCLUDE

    public bool Equals(Foo? other)
    {
        if (other is null) return false;

        // Step 5
        // return (this.Number, this.Name) == (other.Number, other.Name);
        return true;
    }

    public override int GetHashCode()
    {
        return (this.Number, this.Name).GetHashCode();
    }

    public static bool operator ==(Foo first, Foo second)
    {
        return first.Equals(second);
    }

    public static bool operator !=(Foo first, Foo second)
    {
        return !(first == second);
    }

    public void Deconstruct(out int num, out string name)
    {
        num = this.Number;
        name = this.Name;
    }
}
