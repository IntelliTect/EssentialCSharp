namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_03
{
    using Listing12_02;

#pragma warning disable CA1720 // Obj is used as typename for clarity when reading text

    public class CellStack
    {
        public virtual object Pop() { return new Cell(); } // would return that last cell added and remove it from the list
        public virtual void Push(Cell obj) { }
    }

#pragma warning restore CA1720 // Obj is used as typename for clarity when reading text
}
