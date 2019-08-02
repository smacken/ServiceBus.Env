using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;

namespace ServiceBus.EnvPlugin
{
    public class EnvPlugin : ServiceBusPlugin
    {
        private readonly string _environment;
        private const string EnvName = "Env";

        public override string Name => nameof(EnvPlugin);
        public override bool ShouldContinueOnException {get; } = false;

        public EnvPlugin(string environment)
        {
            this._environment = environment;
        }

        public EnvPlugin(Environment env)
        {
            this._environment = env.ToString();
        }

        public EnvPlugin(Microsoft.Extensions.Hosting.IHostingEnvironment environment)
        {
            this._environment = environment.EnvironmentName;
        }

        public override Task<Message> BeforeMessageSend(Message message)
        {
            message.UserProperties[EnvName] = this._environment;
            return Task.FromResult(message);
        }
    }
}
