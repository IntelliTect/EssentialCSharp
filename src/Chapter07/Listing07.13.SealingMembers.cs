namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_13;

#region INCLUDE
class A
{
    public virtual void Method()
    {
    }
}

class B : A
{
    public sealed override void Method()
    {
    }
}

class C : B
{
    // ERROR:  Cannot override sealed members
    //public override void Method()
    //{
    //}
}
#endregion INCLUDE
