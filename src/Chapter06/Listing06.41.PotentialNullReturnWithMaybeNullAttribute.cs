
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_41;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Collections.Generic;

public class NullabilityAttributesExamined
{
    static public string? Method() =>
       GetObject(Array.Empty<string>(), (item) => true);
    #region INCLUDE
    // ...
    [return: MaybeNull]
    static public T GetObject<T>(
      IEnumerable<T> sequence, Func<T, bool> match)
    =>
    // ...
    #endregion INCLUDE
        sequence.FirstOrDefault(match);
}
