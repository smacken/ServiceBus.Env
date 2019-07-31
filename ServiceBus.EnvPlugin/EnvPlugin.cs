using System;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;

namespace ServiceBus.EnvPlugin
{
    public class EnvPlugin : ServiceBusPlugin
    {
        private readonly string environment;
        private const string _envName = "Env";

        public override string Name => nameof(EnvPlugin);
        public override bool ShouldContinueOnException {get; } = false;

        public EnvPlugin(string environment)
        {
            this.environment = environment;
        }

        public EnvPlugin(Environment env)
        {
            this.environment = env.ToString();
        }

        public override Task<Message> BeforeMessageSend(Message message)
        {
            if (message.Body == null || message.Body.Length == 0)
            {
                return Task.FromResult(message);
            }

            message.UserProperties[_envName] = this.environment;
            return Task.FromResult(message);
        }

        public override Task<Message> AfterMessageReceive(Message message)
        {
            if (message.Body == null || message.Body.Length == 0)
            {
                return Task.FromResult(message);
            }

            if (message.UserProperties.TryGetValue(_envName, out var env))
            {
                return Task.FromResult(message);
            }
            
            return Task.FromResult(message);
        }
    }
}
