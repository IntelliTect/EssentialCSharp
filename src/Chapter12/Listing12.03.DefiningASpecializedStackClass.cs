namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_03
{
    using Listing12_02;

    public class CellStack
    {
        public virtual object Pop() { return new Cell(); } // would return that last cell added and remove it from the list
        public virtual void Push(Cell obj) { }
    }
}
