namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_11
{
    using System.Threading.Tasks;

    public class Program
    {
        public Task<string> CalculatePiAsync(int digits)
        {
            return Task.Factory.StartNew<string>(
                () => CalculatePi(digits));
        }

        private string CalculatePi(int digits)
        {
            // ...

            return string.Empty;
        }
    }
}

