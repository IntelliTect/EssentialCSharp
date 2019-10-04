namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_29
{
#pragma warning disable CA1000

    public abstract class MathEx<T>
    {
        public static T Add(T first, T second)
        {
            // Error: Operator '+' cannot be applied to 
            // operands of type 'T' and 'T'
            // return first + second;
            return default(T);
        }
    }

#pragma warning restore CA1000
}
