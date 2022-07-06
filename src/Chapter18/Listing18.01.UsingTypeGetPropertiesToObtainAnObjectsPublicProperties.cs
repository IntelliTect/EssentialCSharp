namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_01
{
    using System;
    using System.Reflection;

    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            DateTime dateTime = new DateTime();

            Type type = dateTime.GetType();
            foreach(
                System.Reflection.PropertyInfo property in
                    type.GetProperties())
            {
                Console.WriteLine(property.Name);
            }
            #endregion INCLUDE
        }
    }
}