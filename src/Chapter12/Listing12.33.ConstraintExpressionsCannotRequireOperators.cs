namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_33
{
    public abstract class MathEx<T>
    {
#if INVALID_CODE
        public static T Add(T first, T second)
        {
            // Error: Operator '+' cannot be applied to 
            // operands of type 'T' and 'T'
            // return first + second;
        }
#endif
    }
}
