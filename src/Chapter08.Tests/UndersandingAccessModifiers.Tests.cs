using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.UndersatndingAccessModifiers.Tests
{
    // Justification: Use for example only.
#pragma warning disable IDE0051 // Remove unused private members
    public interface ISampleInterface
    {
        // public has no impact on a standard interface method.
        string InterfaceMethod1();
        string InterfaceMethod2();
        public string InterfaceMethod3();
        private string PrivateConcreteInterfaceMethod() => Thing.GetStackTrace();
        protected string ProtectedConcreteInterfaceMethod() => Thing.GetStackTrace();
        protected string ProtectedInterfaceMethod();

        // "public" is the default and therefore optional 
        string PublicConcreteInterfaceMethod() => Thing.GetStackTrace();
    }

    public interface IMoreInformation : ISampleInterface
    {
        // Use abstract or a concrete implementation.
        string ISampleInterface.InterfaceMethod2() => ((IMoreInformation)this).ProtectedConcreteInterfaceMethod();
        abstract string ISampleInterface.InterfaceMethod3();

        /* protected */
        string ISampleInterface.ProtectedInterfaceMethod() =>
            ((IMoreInformation)this).ProtectedConcreteInterfaceMethod();

        /* public */
        //string ISampleInterface.PublicConcreteInterfaceMethod() => 
        //    Self-invokes causing infinate loop
        //    ((ISampleInterface)this).PublicConcreteInterfaceMethod();

        //string ISampleInterface.PublicConcreteInterfaceMethod() =>
        //    Self-invokes causing infinate loop
        //    PublicConcreteInterfaceMethod();
    }
    public class Information : IMoreInformation
    {
        public string InterfaceMethod1() => Thing.GetStackTrace();

        public string CallConcreteInterfaceMethod2() => ((IMoreInformation)this).InterfaceMethod2();

        // ((IMoreInformation)this).InterfaceMethod3() creates an infinite loop
        public string InterfaceMethod3() => Thing.GetStackTrace();

        // Protected default interface members are not accessible from the implementing class
        // string ISampleInterface.ProtectedConcreteInterfaceMethod() =>
        //    ((IMoreInformation)this).ProtectedConcreteInterfaceMethod();

        string ISampleInterface.ProtectedConcreteInterfaceMethod() => Thing.GetStackTrace();

        public string CallConcreteInterfaceMethod3() =>
            // Same as casting to ISampleInterface
            ((ISampleInterface)this).PublicConcreteInterfaceMethod();

        virtual public string PublicConcreteInterfaceMethod() => Thing.GetStackTrace();
    }
    public class SubClass : Information
    {
        new public string PublicConcreteInterfaceMethod() => Thing.GetStackTrace();
    }
#pragma warning restore IDE0051 // Remove unused private members



    static public class Thing
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetStackTrace()
        {
            StackTrace stackTrace = new StackTrace();
            string?[] frames = stackTrace.GetFrames().Skip(1).Where(
                item =>
                    item!.GetMethod()!.DeclaringType!.Assembly == Assembly.GetExecutingAssembly()
                ).Where(
                item =>
                    !item!.GetMethod()!.DeclaringType!.Name!.EndsWith("Tests")
                ).Select(
                    item => $"{item!.GetMethod()!.ReflectedType!.Name}.{item.GetMethod()!.Name.Replace($"{item!.GetMethod()!.ReflectedType!.Namespace}.", "")}").Reverse().ToArray();
            return string.Join("=>", frames);
        }


        [TestClass]
        public class AccessibilityModifierTests
        {
            [TestMethod]
            public void InterfaceMethod1()
            {
                Information information = new Information();
                Assert.AreEqual($"{nameof(Information)}.{nameof(Information.InterfaceMethod1)}",
                    information.InterfaceMethod1());
            }

            [TestMethod]
            public void InterfaceMethod2()
            {
                Information information = new Information();
                Assert.AreEqual(
                    string.Join("=>",
                        new string[]{
                        $"{nameof(Information)}.{nameof(Information.CallConcreteInterfaceMethod2)}",
                        $"{nameof(IMoreInformation)}.{nameof(ISampleInterface)}.{nameof(ISampleInterface.InterfaceMethod2)}",
                        $"{nameof(Information)}.{nameof(ISampleInterface)}.ProtectedConcreteInterfaceMethod"
                        }),
                    information.CallConcreteInterfaceMethod2());
            }
            [TestMethod]
            public void InterfaceMethod3()
            {
                Information information = new Information();
                Assert.AreEqual(
                    $"{nameof(Information)}.{nameof(Information.InterfaceMethod3)}",
                    information.InterfaceMethod3());
            }

            [TestMethod]
            public void CallConcreteInterfaceMethod3()
            {
                Information information = new Information();
                Assert.AreEqual(
                    // Information.CallConcreteInterfaceMethod3=>ISampleInterface.PublicConcreteInterfaceMethod>. 
                    string.Join("=>",
                        new string[]{
                        $"{nameof(Information)}.{nameof(Information.CallConcreteInterfaceMethod3)}",
                        $"{nameof(Information)}.{nameof(ISampleInterface.PublicConcreteInterfaceMethod)}"
                        }),
                    information.CallConcreteInterfaceMethod3());
            }

            [TestMethod]
            public void ISampleInterfacePublicConcreteInterfaceMethod()
            {
                Information information = new Information();
                Assert.AreEqual(
                    $"{nameof(Information)}.{nameof(ISampleInterface.PublicConcreteInterfaceMethod)}",
                    ((ISampleInterface)information).PublicConcreteInterfaceMethod());
            }

            [TestMethod]
            public void ProtectedConcreteInterfaceMethod()
            {
                SubClass information = new SubClass();
                Assert.AreEqual(
                    $"{nameof(SubClass)}.{nameof(SubClass.PublicConcreteInterfaceMethod)}",
                    information.PublicConcreteInterfaceMethod());
            }

            [TestMethod]
            public void ISampleInterfaceProtectedConcreteInterfaceMethod()
            {
                ISampleInterface information = new SubClass();
                Assert.AreEqual(
                    $"{nameof(Information)}.{nameof(ISampleInterface.PublicConcreteInterfaceMethod)}",
                    information.PublicConcreteInterfaceMethod());
            }
        }
    }
}
