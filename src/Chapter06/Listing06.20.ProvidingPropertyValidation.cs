// ����Ϊ�յ��ֶ�δ��ʼ������������Ϊ�ɿա�
#pragma warning disable CS8618


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_20;

#region INCLUDE
public class Employee
{
    // ...
    public void Initialize(
        string newFirstName, string newLastName)
    {
        // ʹ��Employee�������
        FirstName = newFirstName;
        LastName = newLastName;
    }

    // LastName����
    public string LastName
    {
        get => _LastName;
        set
        {
            // #region EXCLUDE
#if !NET7_0_OR_GREATER
            // ��֤��LastName�ĸ�ֵ
            value = value?.Trim() ?? throw new ArgumentNullException(nameof(value));
            if(value.Length == 0)
            {
                // �������
                throw new ArgumentException(
                    "LastName����Ϊ�մ���Ҳ�����ɿհ��ַ����ɡ�", nameof(value));
            }
#else
            // #endregion EXCLUDE
            #region HIGHLIGHT
            // ��֤��LastName�ĸ�ֵ
            
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
    // FirstName����
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            #if !NET7_0_OR_GREATER
            // ��֤��FirstName�ĸ�ֵ
            value = value?.Trim() ?? throw new ArgumentNullException(nameof(value));
            if (value.Length == 0)
            {
                // �������
                throw new ArgumentException(
                    "LastName����Ϊ�մ�����ֻ�ɿհ��ַ����ɡ�", nameof(value));
            }
            #else // NET7_0_OR_GREATER
            // ��֤��LastName�ĸ�ֵ
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            #endif // NET7_0_OR_GREATER
            _FirstName = value;
        }
    }
    private string _FirstName;
#endregion EXCLUDE
}
#endregion INCLUDE
