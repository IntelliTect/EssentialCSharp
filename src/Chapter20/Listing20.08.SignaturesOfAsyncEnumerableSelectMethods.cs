/*
#region INCLUDE
namespace System.Linq
#region EXCLUDE
 */
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_08
#endregion EXCLUDE
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
        IAsyncEnumerable<TResult> SelectAwaitWithCancellation<
    #endregion HIGHLIGHT
        TSource?, TResult?>(
            this IAsyncEnumerable<TSource> source,
            Func<TSource, CancellationToken, 
                ValueTask<TResult>> selector);
    // ...
}
#endregion INCLUDE
