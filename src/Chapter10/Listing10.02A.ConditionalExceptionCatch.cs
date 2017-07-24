namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_02A
{
    using System;
    using System.Collections.Generic;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            Func<bool> ThrowInvalidOperationException = () => { throw new InvalidOperationException(); };

            try
            {
                List<string> locations = new List<string>();
                try
                {
                    // ...


                    throw new System.ComponentModel.Win32Exception(42, "Custom error");
                }
                catch (System.ComponentModel.Win32Exception exception)
                    when (exception.NativeErrorCode == 42)
                {
                    bool exceptionHandled = false;

                    Console.WriteLine("Inside Win32Exception catch block");

                    if (!exceptionHandled)
                    {
                        throw;
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}