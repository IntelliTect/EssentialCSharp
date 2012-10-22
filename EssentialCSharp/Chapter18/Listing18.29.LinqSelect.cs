namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_29
{
    using System.Collections.Generic;
    using System.Linq;

    class Cryptographer
    {
        // ...
        public List<string>
          Encrypt(IEnumerable<string> data)
        {
            return data.Select(
                item => Encrypt(item)).ToList();
        }

        // ...

        private string Encrypt(string item)
        {
            // ...
            throw new System.NotImplementedException();
        }
    }
}


