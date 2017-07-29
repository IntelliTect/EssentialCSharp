namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_31
{
    using System;
    using Listing17_32;
    public class Program
    {
        public static void Main()
        {
            dynamic person = DynamicXml.Parse(
             @"<Person>
                <FirstName>Inigo</FirstName>
                <LastName>Montoya</LastName>
               </Person>");

            Console.WriteLine(
                $"{ person.FirstName } { person.LastName }");
        }
    }
}