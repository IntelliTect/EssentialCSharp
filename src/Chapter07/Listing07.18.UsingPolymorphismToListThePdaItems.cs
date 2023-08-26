namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_18;

using System;
using Listing07_17;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        PdaItem[] pda = new PdaItem[3];

        Contact contact = new("Sherlock Holmes")
        {
            Address = "221B Baker Street, London, England"
        };
        pda[0] = contact;

        Appointment appointment = new(
               "Soccer tournament", "Estádio da Machava", 
               new DateTime(2008, 7, 18), new DateTime(2008, 7, 19));
        pda[1] = appointment;

        contact = new Contact("Anne Frank")
        {
            Address = "Apt 56B, Whitehaven Mansions, Sandhurst Sq, London"
        };
        pda[2] = contact;

        List(pda);
    }

    public static void List(PdaItem[] items)
    {
        // Implemented using polymorphism. The derived
        // type knows the specifics of implementing 
        // GetSummary().
        foreach(PdaItem item in items)
        {
            Console.WriteLine("________");
            Console.WriteLine(item.GetSummary());
        }
    }
}
#endregion INCLUDE
