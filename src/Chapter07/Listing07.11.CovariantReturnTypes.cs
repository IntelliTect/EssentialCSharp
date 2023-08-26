#pragma warning disable IDE0059 // Unnecessary assignment of a value
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_11;

#region INCLUDE
public class Base
{
    public virtual Base Create() => new();
}

public class Derived : Base
{
    public override Derived Create() => new();
}
#endregion INCLUDE
