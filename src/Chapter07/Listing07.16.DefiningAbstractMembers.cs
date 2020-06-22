namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_16
{
    using System;
    using static System.Environment;

    // Define an abstract class
    public abstract class PdaItem
    {
        public PdaItem(string name)
        {
            Name = name;
        }

        public virtual string Name { get; set; }
        public abstract string GetSummary();
    }
    public class Contact : PdaItem
    {
        public Contact(string name)
            : base(name)
        {
        }

        public override string Name
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }

            set
            {
                string[] names = value.Split(' ');
                // Error handling not shown
                FirstName = names[0];
                LastName = names[1];
            }
        }

        public string FirstName
        {
            get
            {
                return _FirstName!;
            }
            set
            {
                _FirstName = value ?? throw new ArgumentNullException(nameof(value)); ;
            }
        }
        private string? _FirstName;

        public string LastName
        {
            get
            {
                return _LastName!;
            }
            set
            {
                _LastName = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        private string? _LastName;

        public string? Address { get; set; }

        public override string GetSummary()
        {
            return $"FirstName: { FirstName + NewLine }"
            + $"LastName: { LastName + NewLine }"
            + $"Address: { Address + NewLine }";
        }

        // ...
    }

    public class Appointment : PdaItem
    {
        public Appointment(string name, 
            string location, DateTime startDateTime, DateTime endDateTime) :
            base(name)
        {
            Location = location;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }

        // ...
        public override string GetSummary()
        {
            return $"Subject: { Name + NewLine }"
                + $"Start: { StartDateTime + NewLine }"
                + $"End: { EndDateTime + NewLine }"
                + $"Location: { Location }";
        }
    }
}
