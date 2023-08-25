namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_05;

#region INCLUDE

public class Program
{
    public static void Main()
    {
        Type type;
        type = typeof(System.Nullable<>);
        Console.WriteLine(type.ContainsGenericParameters);
        Console.WriteLine(type.IsGenericType);

        type = typeof(System.Nullable<DateTime>);
        Console.WriteLine(type.ContainsGenericParameters);
        Console.WriteLine(type.IsGenericType);
    }
}
#endregion INCLUDE
