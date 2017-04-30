namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_04
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
            catch (Exception )
            {
                // Handle Exception
            }
            // Disabled warning as this code is demonstrating the general catch block
            // following a catch(Exception ) block.
            #pragma warning disable 1058
            catch
            {
                // Any unhandled exception
            }
            finally
            {
                // Handle any cleanup code here as it runs
                // regardless of whether there is an exception
            }
        }
    }
}