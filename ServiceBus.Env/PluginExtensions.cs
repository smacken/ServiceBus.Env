using System;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;

namespace ServiceBus.Env
{
    public static class PluginExtensions
    {
        public static ServiceBusPlugin RegisterEnvPlugin(this ClientEntity client, string env)
        {
            return client.RegisterEnvPlugin();
        }

        public static ServiceBusPlugin RegisterEnvPlugin(this ClientEntity client)
        {
            ServiceBusPlugin plugin = new EnvPlugin();
            client.RegisterPlugin(plugin);
            return plugin;
        }
    }
}