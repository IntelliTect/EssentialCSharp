// 不可为空的字段未初始化。考虑声明为可空。
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_59;

using System;

#region INCLUDE
// 文件: Person.Designer.cs
public partial class Person
{
    #region Extensibility Method Definitions
    #region HIGHLIGHT
    static partial void OnLastNameChanging(string value);
    static partial void OnFirstNameChanging(string value);
    #endregion HIGHLIGHT
    #endregion Extensibility Method Definitions

    // ...
    public string LastName
    {
        get
        {
            return _LastName;
        }
        set
        {
            if (_LastName != value)
            {
                #region HIGHLIGHT
                OnLastNameChanging(value);
                #endregion HIGHLIGHT
                _LastName = value;
            }
        }
    }
    private string _LastName;

    // ...
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            if (_FirstName != value)
            {
                #region HIGHLIGHT
                OnFirstNameChanging(value);
                #endregion HIGHLIGHT
                _FirstName = value;
            }
        }
    }
    private string _FirstName;

    public partial string GetName();
}

// 文件: Person.cs
partial class Person
{
    static partial void OnLastNameChanging(string value)
    {
        value = value ?? 
            throw new ArgumentNullException(nameof(value));

        if (value.Trim().Length == 0)
        {
            throw new ArgumentException(
                $"{nameof(LastName)}不能空白。",
                nameof(value));
        }
    }

    #region EXCLUDE
    static partial void OnFirstNameChanging(string value)
    {
        value = value ?? 
            throw new ArgumentNullException(nameof(value));

        if (value.Trim().Length == 0)
        {
            throw new ArgumentException(
                $"{nameof(FirstName)}不能空白。",
                nameof(value));
        }
    }
    #endregion EXCLUDE

    public partial string GetName() => $"{FirstName} {LastName}";
}
#endregion INCLUDE
