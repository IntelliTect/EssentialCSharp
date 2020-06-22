namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_31
{
    using System;

    class EntityBase<T> where T : IComparable<T>
    {
        // ...
    }

    // ERROR: 
    // The type 'U' must be convertible to 'System.IComparable<U>' 
    // to use it as parameter 'T' in the generic type or 
    // method
    // class Entity<U> : EntityBase<U>
    // {
    //     ...
    // }
}
