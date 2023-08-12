using System.Data;
using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_33.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_33;

[TestClass]
public class TraceBufferTest
{
    [TestMethod]
    public void TraceBuffer_Output_MatchesExpected()
    {
        using StringWriter stringWriter = new();
        TraceListener traceListener = new TextWriterTraceListener(stringWriter);

        Trace.Listeners.Add(traceListener);

        Program.Main();

        string traceOutput = stringWriter.ToString();
        string expected = $"The connection is currently Disconnecting";

        Assert.IsTrue(traceOutput.Contains(expected));
    }
}

