namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_27
{
    #region INCLUDE
    using System;
    using System.Linq;
    using System.Xml.Linq;

    #region EXCLUDE
    public class Program
    {
        public static void Main()
        {
            #endregion EXCLUDE
            XElement person = XElement.Parse(
                @"<Person>
                    <FirstName>Inigo</FirstName>
                    <LastName>Montoya</LastName>
                  </Person>");

            Console.WriteLine($"{ person.Descendants("FirstName").First().Value }" +
            $"{ person.Descendants("LastName").First().Value }");
            //...
            #endregion INCLUDE
        }
    }
}
