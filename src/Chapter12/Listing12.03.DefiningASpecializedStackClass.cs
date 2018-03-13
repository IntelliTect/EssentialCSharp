namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_03
{
    using Listing11_02;

    public class CellStack
    {
        public virtual object Pop() { return new Cell(); } // would return that last cell added and remove it from the list
        public virtual void Push(Cell obj) { }
    }
}