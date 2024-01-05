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

        // ͨ��PdaItem��������������
        item.Name = "Inigo Montoya";

        // ֤��������FirstName��LastName
        Console.WriteLine(
            $"{ contact.FirstName } { contact.LastName}");
    }
}
#endregion INCLUDE
