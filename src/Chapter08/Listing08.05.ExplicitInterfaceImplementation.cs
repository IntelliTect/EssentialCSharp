// // 说明：出于对当前主题进行解释的目的，只提供部分实现
#pragma warning disable IDE0059 // 不需要赋值

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_05;

using System;
using Listing08_02;

public class Program
{
    public static void Main()
    {
        string?[] values;
        Contact contact = new("Inigo Montoya");

        // ...

        // 错误: 不能在contact上直接调用CellValues
        // values = contact.CellValues;

        // 应首先转型为IListable
        values = ((IListable)contact).CellValues;
        // ...

    }
}

#region INCLUDE
#region HIGHLIGHT
public class Contact : PdaItem, IListable, IComparable
#endregion HIGHLIGHT
{
    #region EXCLUDE
    public Contact(string name)
        : base(name)
    {
    }

    #region IComparable成员
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
            $"参数不是{nameof(Contact)}类型的一个值",
            nameof(obj))
    };
    #endregion
    #endregion EXCLUDE

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
    #endregion EXCLUDE
}
#endregion INCLUDE
