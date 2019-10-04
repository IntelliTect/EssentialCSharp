namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_01
{
#pragma warning disable CA1720 // Obj is used as typename for clarity when reading text
    public class Stack
    {
        public virtual object Pop()
        {
            // ...
            return new object();
        }

        public virtual void Push(object obj)
        {
            // ...
        }

        // ...
    }

#pragma warning restore CA1720 // Obj is used as typename for clarity when reading text
}
