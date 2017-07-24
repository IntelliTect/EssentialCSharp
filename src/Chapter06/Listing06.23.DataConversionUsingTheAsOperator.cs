namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_23
{
    class Program
    {
        static object Print(IDocument document)
        {
            if(document != null)
            {
                // Print document...
            }
            else
            {
            }

            return null;
        }

        static void Main()
        {
            object data = new object();

            // ...

            Print(data as Document);
        }
    }

    internal class Document : IDocument
    {
    }

    internal interface IDocument
    {
    }
}
