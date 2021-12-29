namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_27
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main()
        {
            XElement person = XElement.Parse(
                @"<Person>
                    <FirstName>Inigo</FirstName>
                    <LastName>Montoya</LastName>
                  </Person>");

            Console.WriteLine($"{ person.Descendants("FirstName").First().Value }" +
            $"{ person.Descendants("LastName").First().Value }");
        }
    }
}
