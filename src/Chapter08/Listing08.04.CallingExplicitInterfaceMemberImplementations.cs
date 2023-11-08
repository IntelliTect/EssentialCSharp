// Justification: Only a partial implementation provided for elucidation purposes.
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_04;

using System;
using Listing08_02;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string?[] values;
        Contact contact = new("Inigo Montoya");

        // ...

        #if COMPILEERROR // EXCLUDE
        // ERROR:  Unable to call .CellValues directly
        //         on a contact
        values = contact.CellValues;
        #endif // COMPILEERROR // EXCLUDE

        // First cast to IListable
        #region HIGHLIGHT
        values = ((IListable)contact).CellValues;
        #endregion HIGHLIGHT

        // ...
        #endregion INCLUDE
    }
}

public class Contact : PdaItem, IListable
{
    // ...
    public Contact(string name)
        : base(name)
    {
    }

    #region IListable Members
    string?[] IListable.CellValues
    {
        get
        {
            return new string?[] 
      {
          FirstName,
          LastName,
          Phone,
          Address
      };
        }
    }
    #endregion

    private string? _LastName;
    protected string LastName
    {
        get => _LastName!;
        set => _LastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string? _FirstName;
    protected string FirstName
    {
        get => _FirstName!;
        set => _FirstName = value ?? throw new ArgumentNullException(nameof(value));
    }
    protected string? Phone { get; set; }
    protected string? Address { get; set; }
    public static string GetName(string firstName, string lastName)
        => $"{ firstName } { lastName }";
}