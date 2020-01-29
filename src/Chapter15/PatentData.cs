using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15
{
    public class Patent
    {
        // Title of the published application
        public string Title { get; }

        // The date the application was officially published
        public string YearOfPublication { get; }

        // A unique number assigned to published applications
        public string? ApplicationNumber { get; set; }

        public long[] InventorIds { get; }

        public Patent(
            string title, string yearOfPublication, long[] inventorIds)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            YearOfPublication = yearOfPublication ?? 
                throw new ArgumentNullException(nameof(yearOfPublication));
            InventorIds = inventorIds ?? 
                throw new ArgumentNullException(nameof(inventorIds));
        }

        public override string ToString()
        {
            return $"{ Title } ({ YearOfPublication })";
        }

    }

    public class Inventor
    {
        public long Id { get; }
        public string Name { get; }
        public string City { get; }
        public string State { get; }
        public string Country { get; }

        public Inventor(
            string name, string city, string state, string country, int id)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Country = country ?? throw new ArgumentNullException(nameof(country));
            Id = id;
        }

        public override string ToString()
        {
            return $"{ Name } ({ City }, { State })";
        }

    }

    public static class PatentData
    {
        public static readonly Inventor[] Inventors = new Inventor[]
        {
            new Inventor(
                "Benjamin Franklin", "Philadelphia",
                "PA", "USA", 1),
            new Inventor(
                "Orville Wright", "Kitty Hawk",
                "NC", "USA", 2),
            new Inventor(
                "Wilbur Wright", "Kitty Hawk",
                "NC", "USA", 3),
            new Inventor(
                "Samuel Morse", "New York",
                "NY", "USA", 4),
            new Inventor(
                "George Stephenson", "Wylam",
                "Northumberland", "UK", 5),
            new Inventor(
                "John Michaelis", "Chicago",
                "IL", "USA", 6),
            new Inventor(
                "Mary Phelps Jacob", "New York",
                "NY", "USA", 7)
        };

        public static readonly Patent[] Patents = new Patent[]
        {
            new Patent("Bifocals","1784", inventorIds: new long[] { 1 }),
            new Patent("Phonograph", "1877", inventorIds: new long[] { 1 }),
            new Patent("Kinetoscope", "1888", inventorIds: new long[] { 1 }),
            new Patent("Electrical Telegraph", "1837", inventorIds: new long[] { 4 }),
            new Patent("Flying Machine", "1903", inventorIds: new long[] { 2, 3 }),
            new Patent("Steam Locomotive", "1815", inventorIds: new long[] { 5 }),
            new Patent("Droplet Deposition Apparatus", "1989", inventorIds: new long[] { 6 }),
            new Patent("Backless Brassiere", "1914", inventorIds: new long[] { 7 })
        };
    }
}
