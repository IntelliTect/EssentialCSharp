using System.Data;
using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_33.Tests;

enum ConnectionState
{
    Disconnected,
    Connecting,
    Connected,
    Disconnecting
}

[TestClass]
public class TraceBufferTest
{
    [TestMethod]
    public void TraceBuffer_Output_MatchesExpected()
    {
        using StringWriter stringWriter = new StringWriter();
        TraceListener traceListener = new TextWriterTraceListener(stringWriter);

        Trace.Listeners.Add(traceListener);

        System.Diagnostics.Trace.WriteLine(
            $"The connection is currently {ConnectionState.Disconnecting}");

        string traceOutput = stringWriter.ToString();
        string expected = $"The connection is currently Disconnecting";

        Assert.IsTrue(traceOutput.Contains(expected));
    }
}

