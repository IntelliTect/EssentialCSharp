namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_07
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Contact contact = new Contact();
            contact.Name = "Inigo Montoya";

            // ERROR:  'PdaItem.ObjectKey' is inaccessible
            // due to its protection level
            //contact.ObjectKey = Guid.NewGuid(); //uncomment this line and it will not compile
        }
    }

    public class PdaItem
    {
        protected Guid ObjectKey { get; set; }

        // ...
    }

    public class Contact : PdaItem
    {
        void Save()
        {
            // Instantiate a FileStream using <ObjectKey>.dat
            // for the filename
            FileStream stream = System.IO.File.OpenWrite(
                ObjectKey + ".dat");
        }

        void Load(PdaItem pdaItem)
        {
            // ERROR:  'pdaItem.ObjectKey' is inaccessible
            // due to its protection level
            //pdaItem.ObjectKey =...

            Contact contact = pdaItem as Contact;
            if(contact != null)
            {
                contact.ObjectKey = new Guid();//... 
            }
        }
        // ...
        public string Name { get; set; }
    }
}
