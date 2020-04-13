namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_28
{
    using System;
    using Listing18_29;
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
