using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_15;

#region INCLUDE
public class PdaItem
{
    public PdaItem(string name)
    {
        Name = name;
    }
    public virtual string Name { get; set; }
    // ...
}
public class Contact : PdaItem
{
    // Disable warning since FirstName&LastName set via Name property
    // Non-nullable field is uninitialized.
    #pragma warning disable CS8618
    #region HIGHLIGHT
    public Contact(string name) :
        base(name)
    #endregion HIGHLIGHT
    {
    }
    #pragma warning restore CS8618

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

    [NotNull] [DisallowNull]
    public string FirstName { get; set; }
    [NotNull] [DisallowNull]
    public string LastName { get; set; }

    // ...
}

public class Appointment : PdaItem
{
    public Appointment(string name, string location,
        DateTime startDateTime, DateTime endDateTime) :
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
}
#endregion INCLUDE
