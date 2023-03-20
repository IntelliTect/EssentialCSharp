// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_20;

#region INCLUDE
public class Employee
{
    // ...
    public void Initialize(
        string newFirstName, string newLastName)
    {
        // Use property inside the Employee
        // class as well
        FirstName = newFirstName;
        LastName = newLastName;
    }

    // LastName property
    public string LastName
    {
        get => _LastName;
        set
        {
            // #region EXCLUDE
#if !NET7_0_OR_GREATER
            // Validate LastName assignment
            value = value?.Trim() ?? throw new ArgumentNullException(nameof(value));
            if(value.Length == 0)
            {
                // Report error
                throw new ArgumentException(
                    "LastName cannot be blank or whitespace.", nameof(value));
            }
#else
            // #endregion EXCLUDE
            #region HIGHLIGHT
            // Validate LastName assignment
            
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            #endregion HIGHLIGHT
            // #region EXCLUDE
            #endif // NET7_0_OR_GREATER
            // #endregion EXCLUDE
            _LastName = value;
        }
    }
    private string _LastName;
#region EXCLUDE
    // FirstName property
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            #if !NET7_0_OR_GREATER
            // Validate FirstName assignment
            value = value?.Trim() ?? throw new ArgumentNullException(nameof(value));
            if (value.Length == 0)
            {
                // Report error
                throw new ArgumentException(
                    "LastName cannot be blank or whitespace.", nameof(value));
            }
            #else // NET7_0_OR_GREATER
            // Validate LastName assignment
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            #endif // NET7_0_OR_GREATER
            _FirstName = value;
        }
    }
    private string _FirstName;
#endregion EXCLUDE
}
#endregion INCLUDE
