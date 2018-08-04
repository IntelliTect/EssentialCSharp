namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_17
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<Patent> items;
            Patent[] patents = PatentData.Patents;
            items = patents.OrderBy(
                    patent => patent.YearOfPublication)
                .ThenBy(
                    patent => patent.Title);
            Print(items);
            Console.WriteLine();

            items = patents.OrderByDescending(
                    patent => patent.YearOfPublication)
                .ThenByDescending(
                    patent => patent.Title);
            Print(items);
        }

        private static void Print<T>(IEnumerable<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
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
