namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_04
{
    using System;

    public sealed class Program
    {
        public static void Main()
        {
            try
            {
                // ...
                throw new InvalidOperationException(
                    "Arbitrary exception");
                // ...
            }
            catch (NullReferenceException )
            {
                // Handle NullReferenceException
            }
            catch (ArgumentException )
            {
                // Handle ArgumentException
            }
            catch (InvalidOperationException )
            {
                // Handle ApplicationException
            }
            catch (SystemException )
            {
                // Handle SystemException
            }
            catch (Exception )
            {
                // Handle Exception
            }
            catch
            {
                // Any unhandled exception
            }
            finally
            {
                // Handle any cleanup code here as it runs
                // regardless of an exception or not.
            }
        }
    }
}