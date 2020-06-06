namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_42
{
    interface IReadOnlyPair<T>
    {
        T First { get; }
        T Second { get; }
    }

    interface IPair<T>
    {
        T First { get; set; }
        T Second { get; set; }
    }

    public struct Pair<T> : IPair<T>, IReadOnlyPair<T>
    {
        // ...
        #region Generated Interface Stub
        public T First
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public T Second
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
        #endregion Generated Interface Stub
    }

    class Program
    {
        static void Main()
        {
            // Error: Only theoretically possible without 
            // the out type parameter modifier
            //Pair<Contact> contacts =
            //    new Pair<Contact>(
            //        new Contact("Princess Buttercup"),
            //        new Contact("Inigo Montoya"));
            //IReadOnlyPair<PdaItem> pair = contacts;
            //PdaItem pdaItem1 = pair.First;
            //PdaItem pdaItem2 = pair.Second;
        }
    }
}
