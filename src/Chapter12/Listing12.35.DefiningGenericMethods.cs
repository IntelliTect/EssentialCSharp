namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_35
{
    using System;

    public static class MathEx
    {
        public static T Max<T>(T first, params T[] values)
            where T : IComparable<T>
        {
            T maximum = first;
            foreach(T item in values)
            {
                if(item.CompareTo(maximum) > 0)
                {
                    maximum = item;
                }
            }
            return maximum;
        }

        public static T Min<T>(T first, params T[] values)
            where T : IComparable<T>
        {
            T minimum = first;

            foreach(T item in values)
            {
                if(item.CompareTo(minimum) < 0)
                {
                    minimum = item;
                }
            }
            return minimum;
        }
    }
}
