using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_14z

{
    public interface ISample
    {
        protected string Method1() => "ISample.Method1";
        protected string Method2();
    }
    public interface ISubSample : ISample
    {
        string Method3() => $"{Method1()} & { Method2() }";
    }
    public class Sample : ISubSample
    {
        // Must be implemented explicitly
        // with the ("ISample." prefix)
        string ISample.Method2() => "Sample.Method2";
        public void Method4()
        {
            Sample sample = new Sample();
            // Protected members cannot be invoked
            // by implementing class even when
            //  implemented in the class.
            // ((ISample)sample).Method1();
            // ((ISample)sample).Method2();
            ((ISubSample)sample).Method3();
        }
    }

    public class Program
    {
        static public void Main()
        {
            Sample sample = new Sample();
            // Output:
            // ISample.Method1 & Sample.Method2
            Console.WriteLine(
                ((ISubSample)sample).Method3());
        }
    }
}
