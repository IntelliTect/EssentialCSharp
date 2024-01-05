namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_04;

using Listing07_03;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        // 派生类型可以隐式转换为基类型
        Contact contact = new();
        #region HIGHLIGHT
        PdaItem item = contact;
        #endregion HIGHLIGHT
        // ...

        // 基类型则必须显式转型为派生类型
        #region HIGHLIGHT
        contact = (Contact)item;
        #endregion HIGHLIGHT
        // ...
    }
}
#endregion INCLUDE
