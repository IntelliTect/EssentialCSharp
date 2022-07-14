namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_12
{
    #region INCLUDE
    class A
    {
        public virtual void Method()
        {
        }
    }

    class B : A
    {
        public override sealed void Method()
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
}
