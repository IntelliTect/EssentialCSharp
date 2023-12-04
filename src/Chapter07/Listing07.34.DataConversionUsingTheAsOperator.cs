namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_34;

#region INCLUDE
public class PdaItem
{
    protected Guid ObjectKey { get; }
    // ...
}

public class Contact : PdaItem
{
    // ...
    public Contact(string name) => Name = name;

    public static Contact Load(PdaItem pdaItem)
    {
        Contact? contact = pdaItem as Contact;
        if (contact is not null)
        {
            Console.WriteLine(
                $"ObjectKey: {contact.ObjectKey}");
            return (Contact)pdaItem;
        }
        else
        {
            throw new ArgumentException(
                $"{nameof(pdaItem)} was not of type {nameof(Contact)}");
        }
    }
    #region EXCLUDE
    public string Name { get; set; }
    #endregion EXCLUDE
}
#endregion INCLUDE
