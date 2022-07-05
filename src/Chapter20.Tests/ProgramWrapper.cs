using System;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests
{
    public class ProgramWrapper
    {
        Func<string[], Task> MainMethod { get; }

        public ProgramWrapper(
            Func<string[], Task> mainMethod)
        {
            MainMethod = mainMethod;
        }

        async public Task Main(string[] args)
        {
            await MainMethod(args);
        }
    }
}
