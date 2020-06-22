using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Table08_01
{
    // 1.
    namespace StaticMembers
    {
        public interface ISampleInterface
        {
            static string? _Field;
            public static string? Field { get => _Field; private set => _Field = value; }
            static ISampleInterface() => Field = "Nelson Mandela";
            public static string? GetField() => Field;
        }
    }

    // 2.
    namespace ImplementedPropertiesAndMethods
    {
        public interface IPerson
        {
            // Standard abstract property definnitions
            string FirstName { get; set; }
            string LastName { get; set; }

            // Implemented instance properties and methods
            public string Name { get => GetName(); }
            public string GetName() => $"{FirstName} {LastName}";
        }
        public class Person : IPerson
        {
            public Person(string firstName, string lastName)
            {
                (FirstName, LastName) = (firstName, lastName);
            }
            private string? _FirstName;
            public string FirstName
            {
                get => _FirstName!;
                set => _FirstName = value ?? throw new ArgumentNullException(nameof(value));
            }
            private string? _LastName;
            public string LastName
            {
                get => _LastName!;
                set => _LastName = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public class Employee : Person
        {
            public Employee(string firstName, string lastName)
                : base(firstName, lastName) { }
            public string Name => $"{LastName}, {FirstName}";
        }
        public class Program
        {
            static public void Main()
            {
                Person inigo = new Person("Inigo", "Montoya");
                Console.WriteLine(
                    ((IPerson)inigo).Name);
                Employee employee = new Employee("Mark", "Michaelis");
                Console.WriteLine(
                    ((IPerson)employee).Name);
                Console.WriteLine(
                    employee.Name);
            }
        }
    }

    // 3.
    namespace PublicAccessModifiers
    {
        public interface IPerson
        {
            // All members are public by default
            string FirstName { get; set; }
            public string LastName { get; set; }
            string Initials => $"{FirstName[0]}{LastName[0]}";
            public string Name => GetName();
            public string GetName() => $"{FirstName} {LastName}";
        }
    }

    // 4.
    namespace ProtectedAccessModifiers
    {
        
    }

    // 5. 
    namespace ProvateAccessModifiers
    {
        public interface IPerson
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            string Name => GetName();
            private string GetName() =>
                $"{FirstName} {LastName}";
        }
    }

    // 6. 
    namespace InternalAccessModifiers
    {
        public interface IPerson
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            string Name => GetName();
            internal string GetName() =>
                $"{FirstName} {LastName}";
        }
    }

    // 7. 
    namespace ProtectedInternalAccessModifiers
    {
        public interface IPerson
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            string Name => GetName();
            protected internal string GetName() =>
                $"{FirstName} {LastName}";
        }
    }

    // 8. 
    namespace PrivateProtectedAccessModifiers
    {
    class Program
    {
        static void Main()
        {
            IPerson? person = null;
            // Non-deriving classes cannot call
            // private protected member.
            // person?.GetName();
            Console.WriteLine(person);
        }
    }
    public interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        string Name => GetName();
        private protected string GetName() =>
            $"{FirstName} {LastName}";
    }
    public interface IEmployee: IPerson
    {
        int EmpoyeeId => GetName().GetHashCode();
    }
    public class Person : IPerson
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName ??
                throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? 
                throw new ArgumentNullException(nameof(lastName));
        }
        public string FirstName { get; }
        public string LastName { get; }

        // private protected interface members
        // are not accessible in derived classes.
       
        // public int PersonTitle => 
        //      GetName().ToUpper();
    }
    }

    // 9. 
    namespace VirtualMembers
    {
        public interface IPerson
        {
            // virtual is not allowed on members
            // without implementation
            /* virtual */ string FirstName { get; set; }
            string LastName { get; set; }
            virtual string Name => GetName();
            private string GetName() =>
                $"{FirstName} {LastName}";
        }
    }

    // 10.
    namespace SealedMembers
    {
        public interface IWorkflowActivity
        {
            // Private and, therefore, not virtual
            private void Start() =>
                Console.WriteLine(
                    "IWorkflowActivity.Start()...");

            // Sealed to prevent overriding.
            sealed void Run()
            {
                try
                {
                    Start();
                    InternalRun();
                }
                finally
                {
                    Stop();
                }
            }

            protected void InternalRun();

            // Private and, therefore, not virtual
            private void Stop() =>
                Console.WriteLine(
                    "IWorkflowActivity.Stop()..");
        }
    }

    // 11. 
    namespace AbstractMembers
    {
        public interface IPerson
        {
            // abstract is not allowed on members
            // with implementation
            /* virtual */ abstract string FirstName { get; set; }
            string LastName { get; set; }
            // abstract is not allowed on members
            // with implementation
            /* abstract */ string Name => GetName();
            private string GetName() =>
                $"{FirstName} {LastName}";
        }
    }

    // 12. 
    namespace PartialMembers
    {
        public partial interface IThing
        {
            string Value { get; protected set; }
            void SetValue(string value)
            {
                AssertValueIsValid(value);
                Value = value;
            }

            partial void AssertValueIsValid(string value);
        }

        public partial interface IThing
        {
            partial void AssertValueIsValid(string value)
            {
                // Throw if value is invalid.
                switch (value)
                {
                    case null:
                        throw new ArgumentNullException(
                            nameof(value));
                    case "":
                        throw new ArgumentException(
                            "Empty string is invalid", nameof(value));
                    case string _ when string.IsNullOrWhiteSpace(value):
                        throw new ArgumentException(
                            "Can't be whitespace", nameof(value));
                };
            }
        }
    }
}
