namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_02
{
#pragma warning disable 0168 // Disabled warning for unused variables for elucidation
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_01;
    using System;
    using System.ComponentModel;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                throw new Win32Exception(42);
                //TextNumberParser.Parse("negative forty-two");
                // ...
                throw new InvalidOperationException(
                    "Arbitrary exception");
                // ...
            }
            catch(Win32Exception exception) 
                when(args.Length == exception.NativeErrorCode)
            {

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
            finally
            {
                // Handle any cleanup code here as it runs
                // regardless of whether there is an exception
            }
        }
    }
}