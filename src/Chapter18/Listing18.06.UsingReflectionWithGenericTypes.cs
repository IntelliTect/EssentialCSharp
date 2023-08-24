namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_06;

#region INCLUDE

public class Program
{
    public static void Main()
    {
        Stack<int> s = new();

        Type t = s.GetType();

        foreach(Type type in t.GetGenericArguments())
        {
            System.Console.WriteLine(
                "Type parameter: " + type.FullName);
        }
        //...
    }
}
#endregion INCLUDE
