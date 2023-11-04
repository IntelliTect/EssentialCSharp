
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_42;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Collections.Generic;

public class NullabilityAttributesExamined
{
    public static string? Method() =>
       GetObject(Array.Empty<string>(), (item) => true);
    #region INCLUDE
    // ...
    [return: MaybeNull]
    public static T GetObject<T>(
      IEnumerable<T> sequence, Func<T, bool> match)
    =>
    // ...
    #endregion INCLUDE
        sequence.FirstOrDefault(match);
}
