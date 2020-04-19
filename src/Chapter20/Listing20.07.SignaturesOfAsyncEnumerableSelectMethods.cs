namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07
{
}

namespace System.Linq
{
    public static class AsyncEnumerable
    {
        // ...
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
        // ...
    }
}
