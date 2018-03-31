namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_16
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Patent> patents = PatentData.Patents;
            bool result;
            patents = patents.Where(
                patent =>
                {
                    if(result =
                        patent.YearOfPublication.StartsWith("18"))
                    {
                        // Side effects like this in a predicate
                        // are used here to demonstrate a 
                        // principle and should generally be
                        // avoided
                        Console.WriteLine("\t" + patent);
                    }
                    return result;
                });

            Console.WriteLine("1. Patents prior to the 1900s are:");
            foreach(Patent patent in patents)
            {
            }

            Console.WriteLine();
            Console.WriteLine(
                "2. A second listing of patents prior to the 1900s:");
            Console.WriteLine(
                $@"   There are { patents.Count()
                    } patents prior to 1900.");


            Console.WriteLine();
            Console.WriteLine(
                "3. A third listing of patents prior to the 1900s:");
            patents = patents.ToArray();
            Console.Write("   There are ");
            Console.WriteLine(
                $"{ patents.Count() } patents prior to 1900.");
        }
    }

    public class Patent
    {
        // Title of the published application
        public string Title { get; set; }

        // The date the application was officially published
        public string YearOfPublication { get; set; }

        // A unique number assigned to published applications
        public string ApplicationNumber { get; set; }

        public long[] InventorIds { get; set; }

        public override string ToString()
        {
            return $"{ Title } ({ YearOfPublication })";
        }
    }

    public class Inventor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{ Name } ({ City }, { State })";
        }
    }

    public static class PatentData
    {
        public static readonly Inventor[] Inventors = new Inventor[]
        {
            new Inventor()
            {
                Name = "Benjamin Franklin",
                City = "Philadelphia",
                State = "PA",
                Country = "USA",
                Id = 1
            },
            new Inventor()
            {
                Name = "Orville Wright",
                City = "Kitty Hawk",
                State = "NC",
                Country = "USA",
                Id = 2
            },
            new Inventor()
            {
                Name = "Wilbur Wright",
                City = "Kitty Hawk",
                State = "NC",
                Country = "USA",
                Id = 3
            },
            new Inventor()
            {
                Name = "Samuel Morse",
                City = "New York",
                State = "NY",
                Country = "USA",
                Id = 4
            },
            new Inventor()
            {
                Name = "George Stephenson",
                City = "Wylam",
                State = "Northumberland",
                Country = "UK",
                Id = 5
            },
            new Inventor()
            {
                Name = "John Michaelis",
                City = "Chicago",
                State = "IL",
                Country = "USA",
                Id = 6
            },
            new Inventor()
            {
                Name = "Mary Phelps Jacob",
                City = "New York",
                State = "NY",
                Country = "USA",
                Id = 7
            },
           };

        public static readonly Patent[] Patents = new Patent[]
        {
            new Patent()
            {
                Title = "Bifocals",
                YearOfPublication = "1784",
                InventorIds = new long[] { 1 }
            },
            new Patent()
            {
                Title = "Phonograph",
                YearOfPublication = "1877",
                InventorIds = new long[] { 1 }
            },
            new Patent()
            {
                Title = "Kinetoscope",
                YearOfPublication = "1888",
                InventorIds = new long[] { 1 }
            },
            new Patent()
            {
                Title = "Electrical Telegraph",
                YearOfPublication = "1837",
                InventorIds = new long[] { 4 }
            },
            new Patent()
            {
                Title = "Flying Machine",
                YearOfPublication = "1903",
                InventorIds = new long[] { 2, 3 }
            },
            new Patent()
            {
                Title = "Steam Locomotive",
                YearOfPublication = "1815",
                InventorIds = new long[] { 5 }
            },
            new Patent()
            {
                Title = "Droplet Deposition Apparatus",
                YearOfPublication = "1989",
                InventorIds = new long[] { 6 }
            },
            new Patent()
            {
                Title = "Backless Brassiere",
                YearOfPublication = "1914",
                InventorIds = new long[] { 7 }
            },
        };
    }
}
