namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_30
{
    using Listing12_29;
    using System;
    #region INCLUDE
    public class Order : EntityBase<Guid>
    {
        public Order(Guid key) :
            base(key)
        {
            // ...
        }
    }

    public class OrderFactory : IEntityFactory<Guid, Order>
    {
        public Order CreateNew(Guid key)
        {
            return new Order(key);
        }
    }
    #endregion INCLUDE
}
