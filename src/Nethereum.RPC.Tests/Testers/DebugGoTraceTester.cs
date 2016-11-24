using System;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.DebugGeth;
using Xunit;

namespace Nethereum.RPC.Tests.Testers
{
    public class DebugGoTraceTester : RPCRequestTester<object>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldAlwaysReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.Null(result);
        }

        public override async Task<object> ExecuteAsync(IClient client)
        {
            var debugGoTrace = new DebugGoTrace(client);
            return await debugGoTrace.SendRequestAsync(Settings.GetDefaultLogLocation(), 10);
        }

        public override Type GetRequestType()
        {
            return typeof(DebugGoTrace);
        }
    }
}
        