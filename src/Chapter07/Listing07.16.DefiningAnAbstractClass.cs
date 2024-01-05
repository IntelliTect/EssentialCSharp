namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_16;

// 若有一个具体的实现，就可以使用PdaItem对象了
#pragma warning disable CS0168
#region INCLUDE
// 定义抽象类
#region HIGHLIGHT
public abstract class PdaItem
#endregion HIGHLIGHT
{
    public PdaItem(string name)
    {
        Name = name;
    }

    public virtual string Name { get; set; }
}

public class Program
{
    public static void Main()
    {

#if COMPILEERROR // EXCLUDE
        // 错误: 无法创建抽象类型或接口的实例
        PdaItem item = new("Inigo Montoya");
#endif // COMPILEERROR // EXCLUDE
    }
}
#endregion INCLUDE
#pragma warning restore CS0168

