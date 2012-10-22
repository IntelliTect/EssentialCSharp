namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_19
{
    using System;

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
        public Contact(string name) : base(name)
        {
        }

        public override string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }

            set
            {
                string[] names = value.Split(' ');
                // Error handling not shown.
                FirstName = names[0];
                LastName = names[1];
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public override string GetSummary()
        {
            return string.Format(
                "FirstName: {0}\n"
                + "LastName: {1}\n"
                + "Address: {2}", FirstName, LastName, Address);
        }

        // ...
    }

    public class Appointment : PdaItem
    {
        public Appointment(string name) :
            base(name)
        {
            Name = name;
        }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }

        // ...
        public override string GetSummary()
        {
            return string.Format(
                "Subject: {0}" + Environment.NewLine
                + "Start: {1}" + Environment.NewLine
                + "End: {2}" + Environment.NewLine
                + "Location: {3}",
                Name, StartDateTime, EndDateTime, Location);
        }
    }
}
