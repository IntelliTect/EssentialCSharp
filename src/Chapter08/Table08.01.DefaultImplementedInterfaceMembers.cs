namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Table08_01
{
    // 1.
    namespace StaticMembers
    {
        public interface ISampleInterface
        {
            private static string? _Field;
            public static string? Field
            {
                get => _Field;
                private set => _Field = value;
            }
            static ISampleInterface() =>
                Field = "Nelson Mandela";
            public static string? GetField() => Field;
        }
    }

    // 2.
    namespace ImplementedPropertiesAndMethods
    {
        public interface IPerson
        {
            // 标准的抽象属性定义
            string FirstName { get; set; }
            string LastName { get; set; }

            // 实现的实例属性和方法
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
            public static void Main()
            {
                Person inigo = new("Inigo", "Montoya");
                Console.WriteLine(
                    ((IPerson)inigo).Name);
                Employee employee = new("Mark", "Michaelis");
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
            // 所有成员默认public
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
    namespace PrivateAccessModifiers
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
#if COMPILEERROR // EXCLUDE
            // 错误CS0122 'IPerson.GetName()'因为它的保护级别而不可访问
            // 没有派生类可以调用private protected成员
            _ = person?.GetName();
#endif // COMPILEERROR // EXCLUDE
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

        public interface IEmployee : IPerson
        {
            int EmployeeId => GetName().GetHashCode();
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

#if COMPILEERROR // EXCLUDE
        // private protected接口成员不能在实现
        // 该接口的类中访问。
        public string PersonTitle => 
            GetName().ToUpper();
#endif // COMPILEERROR // EXCLUDE
        }
    }

    // 9. 
    namespace VirtualMembers
    {
        public interface IPerson
        {
            // 未提供实现的接口成员不允许virtual
            string FirstName { get; set; }
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
            // 私有，所以非虚
            private static void Start() =>
                Console.WriteLine(
                    "IWorkflowActivity.Start()...");

            // 密封以防止重写
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
            // 私有，所以非虚
            private static void Stop() =>
                Console.WriteLine(
                    "IWorkflowActivity.Stop()..");
        }
    }

    // 11. 
    namespace AbstractMembers
    {
        public interface IPerson
        {
            // 没有实现的成员可以abstract
            /* virtual */
            abstract string FirstName { get; set; }
            string LastName { get; set; }
            // 有实现的成员不允许abstract
            /* abstract */
            string Name => GetName();
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

            static partial void AssertValueIsValid(string value);
        }

        public partial interface IThing
        {
            static partial void AssertValueIsValid(string value)
            {
                // 值无效就抛出异常
                switch (value)
                {
                    case null:
                        throw new ArgumentNullException(
                            nameof(value));
                    case "":
                        throw new ArgumentException(
                            "空串无效", nameof(value));
                    case string _ when string.IsNullOrWhiteSpace(value):
                        throw new ArgumentException(
                            "不能为空白字符", nameof(value));
                };
            }
        }
    }
}
