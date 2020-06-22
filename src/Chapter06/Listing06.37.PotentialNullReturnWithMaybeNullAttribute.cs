
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_37
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    public class NullabilityAttributesExamined
    {
        static public string? Method() =>
           GetObject(new string[0], (item) => true);

        [return: MaybeNull]
        static public T GetObject<T>(
                System.Collections.Generic.IEnumerable<T> sequence, Func<T, bool> match)
                    => sequence.FirstOrDefault(match);
            }
}
