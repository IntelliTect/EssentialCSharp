// Justification: Intentionally demonstrating legacy syntax.
#pragma warning disable IDE1005 // Delegate invocation can be simplified.
using System.ComponentModel;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_39;

public class Person
{
    public event EventHandler PropertyChanged = delegate { };

    private int _BirthYear;
    public int BirthYear
    {
        get { return _BirthYear; }
        set 
        {
            #region INCLUDE
            EventHandler propertyChanged =
                PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this,
                    new PropertyChangedEventArgs(nameof(BirthYear)));
            }
            #endregion INCLUDE

            _BirthYear = value; 
        }
    }

    private int _Age;
    public int Age
    {
        get { return _Age; }
        set
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(nameof(Age)));

            _Age = value;
        }
    }
}
