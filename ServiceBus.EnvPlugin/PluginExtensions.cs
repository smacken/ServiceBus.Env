using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;

namespace ServiceBus.EnvPlugin
{
    public static class PluginExtensions
    {
        public static ServiceBusPlugin RegisterEnvPlugin(this ClientEntity client, Environment env)
        {
            return client.RegisterEnvPlugin(env.ToString());
        }

        public static ServiceBusPlugin RegisterEnvPlugin(this ClientEntity client, string environment)
        {
            ServiceBusPlugin plugin = new EnvPlugin(environment);
            client.RegisterPlugin(plugin);
            return plugin;
        }

        public static TopicClient RegisterEnvPlugin(this TopicClient client, string environment)
        {
            client.RegisterEnvPlugin(environment);
            return client;
        }
    }
}