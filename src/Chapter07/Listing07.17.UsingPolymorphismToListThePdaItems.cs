namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_17
{
    using System;
    using Listing07_16;

    public class Program
    {
        public static void Main()
        {
            PdaItem[] pda = new PdaItem[3];

            Contact contact = new Contact("Sherlock Holmes")
            {
                Address = "221B Baker Street, London, England"
            };
            pda[0] = contact;

            Appointment appointment =
                new Appointment(
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
}
