namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_04
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
            catch (Exception )
            {
                // Handle Exception
            }
            // Disabled warning as this code is demonstrating the general catch block
            // following a catch(Exception ) block
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