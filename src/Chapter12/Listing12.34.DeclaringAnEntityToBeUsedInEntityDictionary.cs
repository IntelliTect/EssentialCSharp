namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_34
{
    using System;
    using Listing12_33;

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
}
