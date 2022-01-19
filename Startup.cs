using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DiscordBot
{
    public class StartUp
    {
        public IConfigurationRoot Configuration { get; }
        public StartUp(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddYamlFile("_config.yml");
            Configuration = builder.Build();
        }

        public static async Task RunAsync(string[] args)
        {
            var startup = new StartUp(args);
            await startup.StartAsync();
    }
}
