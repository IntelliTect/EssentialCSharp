﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_27
{
    using System;

    class EntityBase<T> where T : IComparable<T>
    {
        // ...
    }

    // ERROR: 
    // The type 'T' must be convertible to 'System.IComparable<T>' 
    // to use it as parameter 'T' in the generic type or 
    // method. 
    // class Entity<T> : EntityBase<T>
    // {
    //     ...
    // }
}