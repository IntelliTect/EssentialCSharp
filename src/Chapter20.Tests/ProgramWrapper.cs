
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Runtime.ExceptionServices;
    using System.Threading.Tasks;

    public class ProgramWrapper
    {
        Func<string[],Task> MainMethod { get; }
        private Func<string, IEnumerable<string>, IProgress<DownloadProgressChangedEventArgs>?, Task<int>> FindTextInWebUriMethod { get; }

        public ProgramWrapper(
            Func<string[], Task> mainMethod, 
            Func<string, IEnumerable<string>, 
                IProgress<DownloadProgressChangedEventArgs>?, Task<int>> findTextInWebUriMethod)
        {
            MainMethod = mainMethod;
            FindTextInWebUriMethod = findTextInWebUriMethod;
        }

        async public Task Main(string[] args)
        {
            await MainMethod(args);
        }

        async public Task<int> FindTextInWebUri(
            string findText, IEnumerable<string> urls, IProgress<DownloadProgressChangedEventArgs>? progressCallback)
        {
            return await FindTextInWebUriMethod(findText, urls, progressCallback);
        }
    }

}
