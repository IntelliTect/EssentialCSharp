namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_08
{
}
#region INCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_08
{
    public static class AsyncEnumerable
    {
        // ...
        #region HIGHLIGHT
        public static IAsyncEnumerable<TResult> Select<TSource?, TResult?>(
        #endregion HIGHLIGHT
      this IAsyncEnumerable<TSource> source,
      Func<TSource, TResult> selector);
        #region HIGHLIGHT
        public static IAsyncEnumerable<TResult> SelectAwait<TSource?, TResult?>(
        #endregion HIGHLIGHT
              this IAsyncEnumerable<TSource> source,
              Func<TSource, ValueTask<TResult>>? selector);
        public static
        #region HIGHLIGHT
          IAsyncEnumerable<TResult> SelectAwaitWithCancellation<TSource?, TResult?>(
        #endregion HIGHLIGHT
              this IAsyncEnumerable<TSource> source,
              Func<TSource, CancellationToken, ValueTask<TResult>> selector);
        // ...
    }
}
#endregion INCLUDE
