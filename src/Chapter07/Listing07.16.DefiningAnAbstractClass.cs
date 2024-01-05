namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_16;

// ����һ�������ʵ�֣��Ϳ���ʹ��PdaItem������
#pragma warning disable CS0168
#region INCLUDE
// ���������
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
        // ����: �޷������������ͻ�ӿڵ�ʵ��
        PdaItem item = new("Inigo Montoya");
#endif // COMPILEERROR // EXCLUDE
    }
}
#endregion INCLUDE
#pragma warning restore CS0168

