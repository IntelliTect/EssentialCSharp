namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_48
{
    class Employee
    {
        public Employee(int id)
        {
          _Id = id;
        }

        // ...

        private readonly int _Id;
        public int Id
        {
          get { return _Id; }
        }

        // Error: A readonly field cannot be assigned to (except
        // in a constructor or a variable initializer)

        // public void SetId(int id) =>
        //          _Id = id;

        // ...
    }
}
