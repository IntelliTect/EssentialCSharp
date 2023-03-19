namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_05;

using System.Threading.Tasks;

public class Program
{
    #region INCLUDE
    public async Task<int> DoStuffAsync()
    {
        await DoSomethingAsync();
        await DoSomethingElseAsync();
        return await GetAnIntegerAsync() + 1;
    }
    #endregion INCLUDE

    public Task<int> GetAnIntegerAsync()
    {
        // ...

        throw new System.NotImplementedException();
    }

    public Task DoSomethingElseAsync()
    {
        // ...

        throw new System.NotImplementedException();
    }

    public Task DoSomethingAsync()
    {
        // ...

        throw new System.NotImplementedException();
    }
}






