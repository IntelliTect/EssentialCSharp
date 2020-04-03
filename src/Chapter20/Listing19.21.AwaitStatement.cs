namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_21
{
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        async Task<int> DoStuffAsync()
        {
            await DoSomethingAsync();
            await DoSomethingElseAsync();
            return await GetAnIntegerAsync() + 1;
        }

        private Task<int> GetAnIntegerAsync()
        {
            // ...

            throw new System.NotImplementedException();
        }

        private Task DoSomethingElseAsync()
        {
            // ...

            throw new System.NotImplementedException();
        }

        private Task DoSomethingAsync()
        {
            // ...

            throw new System.NotImplementedException();
        }
    }
}






