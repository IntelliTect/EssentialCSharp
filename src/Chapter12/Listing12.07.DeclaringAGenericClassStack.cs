namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_07
{
    public class Stack<T>
    {
        public Stack(int maxSize)
        {
            InternalItems = new T[maxSize];
        }

        // Use read-only field prior to C# 6.0
        private T[] InternalItems { get; }

        public void Push(T data)
        {
            //...
        }

        public T Pop()
        {
            //...
            return InternalItems[0]; //just for the example
        }
    }
}
