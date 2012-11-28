namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_44
{
    using System;

    class CommonGuid
    {
        public static readonly Guid ComIUnknownGuid =
            new Guid("00000000-0000-0000-C000-000000000046");
        public static readonly Guid ComIClassFactoryGuid =
            new Guid("00000001-0000-0000-C000-000000000046");
        public static readonly Guid ComIDispatchGuid =
            new Guid("00020400-0000-0000-C000-000000000046");
        public static readonly Guid ComITypeInfoGuid =
            new Guid("00020401-0000-0000-C000-000000000046");
        // ...
    }
}
