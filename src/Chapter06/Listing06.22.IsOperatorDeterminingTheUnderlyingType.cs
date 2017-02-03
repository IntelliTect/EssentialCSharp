namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_22
{
    public class AnObject
    {
        public static void Save(object data)
        {
            if(data is string)
            {
                data = Encrypt((string)data);
            }
            // ...
        }

        private static object Encrypt(string data)
        {
            return null;
        }
    }
}
