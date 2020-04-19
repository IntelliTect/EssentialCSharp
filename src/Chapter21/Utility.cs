namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    using System;
    using System.Collections.Generic;

    static class Utility
    {
        public static IEnumerable<string> GetData(int count)
        {
            for(int i = 0; i < count; i++)
                yield return Guid.NewGuid().ToString();
        }
    }
}
