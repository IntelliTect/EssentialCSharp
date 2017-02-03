namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_03
{
    using System;

    public sealed class Program
    {
        public static void ChapterMain()
        {
            try
            {
                // ...
                throw new InvalidOperationException(
                    "Arbitrary exception");
                // ...
            }
            catch(NullReferenceException exception)
            {
                // Handle NullReferenceException
            }
            catch(ArgumentException exception)
            {
                // Handle ArgumentException
            }
            catch(InvalidOperationException exception)
            {
                // Handle ApplicationException
            }
            catch(Exception exception)
            {
                // Handle Exception
            }
            catch
            {
                // Any unhandled exception
            }
        }
    }
}