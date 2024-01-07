namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_03;

using System;
using Listing08_02;

#region INCLUDE
#region HIGHLIGHT
public class Contact : PdaItem, IListable, IComparable
#endregion HIGHLIGHT
{
    #region EXCLUDE
    public Contact(string name)
        : base(name)
    {
        Name = name;
    }
    #endregion EXCLUDE

    #region IComparable Members
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>
    /// 小于零    该实例小于obj
    /// 零        该实例等于obj 
    /// 大于零    该实例大于obj 
    /// </returns>
    public int CompareTo(object? obj) => obj switch
    {
        null => 1,
        Contact contact when ReferenceEquals(this, obj) => 0,
        Contact { LastName: string lastName } 
            when LastName.CompareTo(lastName) != 0 =>
                LastName.CompareTo(lastName),
        Contact { FirstName: string firstName } 
            when FirstName.CompareTo(firstName) != 0 =>
                FirstName.CompareTo(firstName),
        Contact _ => 0,
        _ => throw new ArgumentException(
            $"参数不是{ nameof(Contact) }类型的一个值",
            nameof(obj))
    };
    #endregion

    #region IListable Members
    #region HIGHLIGHT
    string?[] IListable.CellValues
    #endregion HIGHLIGHT
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

    #region EXCLUDE
    public override string Name
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // Split the assigned value into 
            // first and last names
            string[] names;
            names = value.Split(new char[] { ' ' });
            if (names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // 如果未赋全名，就抛出一个异常
                throw new System.ArgumentException(
                    $"所赋的值'{value}'无效。");
            }
        }
    }

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
        set => _FirstName = value??throw new ArgumentNullException( nameof(value)); 
    }
    protected string? Phone { get; set; }
    protected string? Address { get; set; }
    public static string GetName(string firstName, string lastName)
        => $"{ firstName } { lastName }";
    #endregion EXCLUDE
}
#endregion INCLUDE
