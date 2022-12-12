// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Disabled pending constructor
        
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_09;

#region INCLUDE
public class PdaItem
{
    #region HIGHLIGHT
    public virtual string Name { get; set; }
    #endregion HIGHLIGHT
    // ...
}

public class Contact : PdaItem
{
    #region HIGHLIGHT
    public override string Name
    #endregion HIGHLIGHT
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

    public string FirstName { get; set; }
    public string LastName { get; set; }

    // ...
}
#endregion INCLUDE
