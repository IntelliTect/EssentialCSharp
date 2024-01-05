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
    // 错误: 无法重写密封成员
    //public override void Method()
    //{
    //}
}
#endregion INCLUDE
