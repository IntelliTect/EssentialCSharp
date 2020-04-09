namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_06B
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        public static IAsyncEnumerable<TResult> Select<TSource?, TResult?>(
      this IAsyncEnumerable<TSource> source,
      Func<TSource, TResult> selector);
        public static IAsyncEnumerable<TResult> SelectAwait<TSource?, TResult?>(
              this IAsyncEnumerable<TSource> source,
              Func<TSource, ValueTask<TResult>>? selector);
        public static
          IAsyncEnumerable<TResult> SelectAwaitWithCancellation<TSource?, TResult?>(
              this IAsyncEnumerable<TSource> source,
              Func<TSource, CancellationToken, ValueTask<TResult>> selector);

    }
}
