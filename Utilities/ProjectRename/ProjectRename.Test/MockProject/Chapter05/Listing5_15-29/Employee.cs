using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp3.Chapter5.Listing5_09to14
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;

        public string GetName()
        {
            return FirstName + " " + LastName;
        }

        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine("Name changed to '{0}'",
                this.GetName());
        }

        public void Save()
        {
            DataStorage.Store(this);
        }

    }
}
