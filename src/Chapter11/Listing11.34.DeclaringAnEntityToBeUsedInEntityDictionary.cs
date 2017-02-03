namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_34
{
    using System;
    using Listing11_33;

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