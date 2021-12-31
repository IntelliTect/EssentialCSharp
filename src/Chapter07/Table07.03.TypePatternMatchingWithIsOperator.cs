// Build Action set to none.
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Table07_03
{
    public class Program
    {
            // ...
        string id =
            "92e80a67-d453-4998-8d85-f430fa02d6c7"
        if(GetObjectById(id) is Employee employee)
        {
            Display(employee);
        }

        else
        {
            ReportError($"Employee id, {id} is invalid.")
        }


        public static void Save(object data)
        {
            // ...
            else if (data is "")
            {
                return;
                // ...
            }
        }


            // ...
        else (GetObjectById(id) is var result)
        {
            // ...
        }



    // Was existent in the source code already
    public static void Save(object data)
        {
            if (data is string text && text.Length > 0)
            {
                data = Encrypt(text);
                // ...
            }
            else
            {
                throw new ArgumentException();
            }
            // ...

            Console.WriteLine(data);
        }

        private static object Encrypt(string data)
        {
            // See Chapter 19 for actual encryption implementation
            return $"ENCRYPTED <{data}> ENCRYPTED";
        }
    }
}
