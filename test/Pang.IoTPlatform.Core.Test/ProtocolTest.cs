using System;
using System.Runtime.InteropServices;
using Pang.IoTPlatform.Core.MessageQueueProtocol;
using Xunit;
using Xunit.Abstractions;

namespace Pang.IoTPlatform.Core.Test;

public class ProtocolTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public ProtocolTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void UpstreamTest()
    {
        var stream = new UpstreamProtocolStream()
        {
            Protocol = 2
        };

        Assert.Equal("0000000000000010", Convert.ToString(stream.Protocol, 2).PadLeft(Marshal.SizeOf(stream.Protocol.GetType()) * 8, '0'));

        _testOutputHelper.WriteLine(Marshal.SizeOf(stream.Protocol.GetType()).ToString());
    }
}