namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_30
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

            Console.WriteLine("{0} {1}",
              person.Descendants("FirstName").FirstOrDefault().Value,
              person.Descendants("LastName").FirstOrDefault().Value);
        }
    }
}
