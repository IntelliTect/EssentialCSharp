namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_30;

using Listing18_31;
public class Program
{
    public static void Main()
    {
        #region INCLUDE
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
