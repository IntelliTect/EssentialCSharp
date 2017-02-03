namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_29
{
    public abstract class MathEx<T>
    {
        public static T Add(T first, T second)
        {
            // Error: Operator '+' cannot be applied to 
            // operands of type 'T' and 'T'.
            // return first + second;
            return default(T);
        }
    }
}