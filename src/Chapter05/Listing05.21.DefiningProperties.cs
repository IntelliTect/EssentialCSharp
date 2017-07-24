﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_22
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee();

            employee1.Name = "Inigo Montoya";
            System.Console.WriteLine(employee1.Name);

            // ...
        }
    }

    class Employee
    {
        // FirstName property
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        private string _FirstName;

        // LastName property
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
        private string _LastName;
        // ...

        // Name property
        public string Name
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
            set
            {
                // Split the assigned value into 
                // first and last names.
                string[] names;
                names = value.Split(new char[] { ' ' });
                if(names.Length == 2)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                {
                    // Throw an exception if the full 
                    // name was not assigned.
                    throw new System.ArgumentException(
                        $"Assigned value '{ value }' is invalid",
                        "value");
                }
            }
        }

        public string Initials => $"{ FirstName[0] } { LastName[0] }";

        // Title property
        public string Title { get; set; }

        // Manager property
        public Employee Manager { get; set; }
    }
}
