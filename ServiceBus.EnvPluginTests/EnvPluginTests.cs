using System;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Xunit;

namespace ServiceBus.EnvPluginTests
{
    public class EnvPluginTests
    {
        [Fact]
        public async Task ShouldStampMessage()
        {
            var message = new Message(null);
            var env = "Development";

            var plugin = new EnvPlugin.EnvPlugin(env);
            var result = await plugin.BeforeMessageSend(message);

            Assert.Null(result.Body);
            Assert.True(message.UserProperties.ContainsKey("Env"), "Header should have env stamped.");
            Assert.True(message.UserProperties["Env"] == "Development", "Header should have dev env stamped.");
        }
    }
}
