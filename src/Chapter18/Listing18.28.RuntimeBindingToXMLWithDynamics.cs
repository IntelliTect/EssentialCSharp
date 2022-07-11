namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_28
{
    using Listing18_29;
    #region INCLUDE
    using System;
    #region EXCLUDE
    public class Program
    {
        public static void Main()
        {
#endregion EXCLUDE
            dynamic person = DynamicXml.Parse(
             @"<Person>
                <FirstName>Inigo</FirstName>
                <LastName>Montoya</LastName>
               </Person>");

            Console.WriteLine(
                $"{ person.FirstName } { person.LastName }");
            //...
            #endregion INCLUDE
        }
    }
}
