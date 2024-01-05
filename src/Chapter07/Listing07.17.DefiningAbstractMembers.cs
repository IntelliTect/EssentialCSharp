namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_17;

using System;

#region INCLUDE
using static System.Environment;

// 定义抽象类
public abstract class PdaItem
{
    public PdaItem(string name)
    {
        Name = name;
    }

    public virtual string Name { get; set; }
    #region HIGHLIGHT
    public abstract string GetSummary();
    #endregion HIGHLIGHT
}

public class Contact : PdaItem
{
    #region EXCLUDE
    public Contact(string name)
        : base(name)
    {
    }
    #endregion EXCLUDE
    public override string Name
    {
        get
        {
            return $"{ FirstName } { LastName }";
        }
        set
        {
            string[] names = value.Split(' ');
            // 未显示错误处理
            FirstName = names[0];
            LastName = names[1];
        }
    }

    #region HIGHLIGHT
    public string FirstName
    {
        get
        {
            return _FirstName!;
        }
        set
        {
            _FirstName = value ??
                throw new ArgumentNullException(nameof(value)); ;
        }
    }
    private string? _FirstName;
    #endregion HIGHLIGHT

    #region HIGHLIGHT
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
    #endregion HIGHLIGHT
    public string? Address { get; set; }

    #region HIGHLIGHT
    public override string GetSummary()
    {
        return $"名字: { FirstName + NewLine }"
        + $"姓氏: { LastName + NewLine }"
        + $"地址: { Address + NewLine }";
    }
    #endregion HIGHLIGHT

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
    public override string GetSummary()
    {
        return $"主题: { Name + NewLine }"
            + $"开始时间: { StartDateTime + NewLine }"
            + $"结束时间: { EndDateTime + NewLine }"
            + $"地点: { Location }";
    }
}
#endregion INCLUDE
