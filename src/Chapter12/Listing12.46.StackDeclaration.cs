﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_46
{
    using System;
// In an actual implementation we would get/set this
#pragma warning disable 169

    public class Stack<T> where T : IComparable
    {
        T[] items;
        // rest of the class here
    }
#pragma warning restore 169
}