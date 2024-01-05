namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_10;

using System;
using Listing07_09;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        Contact contact;
        PdaItem item;

        contact = new Contact();
        item = contact;

        // 通过PdaItem变量来设置姓名
        item.Name = "Inigo Montoya";

        // 证明已设置FirstName和LastName
        Console.WriteLine(
            $"{ contact.FirstName } { contact.LastName}");
    }
}
#endregion INCLUDE
