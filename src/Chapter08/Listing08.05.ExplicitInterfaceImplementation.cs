// // ˵�������ڶԵ�ǰ������н��͵�Ŀ�ģ�ֻ�ṩ����ʵ��
#pragma warning disable IDE0059 // ����Ҫ��ֵ

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

        // ����: ������contact��ֱ�ӵ���CellValues
        // values = contact.CellValues;

        // Ӧ����ת��ΪIListable
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

    #region IComparable��Ա
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>
    /// С����    ��ʵ��С��obj
    /// ��        ��ʵ������obj 
    /// ������    ��ʵ������obj 
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
            $"��������{nameof(Contact)}���͵�һ��ֵ",
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
