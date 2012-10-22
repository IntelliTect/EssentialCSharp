namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_07
{
    public class Stack<T>
    {
        private T[] _Items;

        public void Push(T data)
        {
            //...
        }

        public T Pop()
        {
            //...
            return _Items[0];//just for the example. 
        }
    }
}