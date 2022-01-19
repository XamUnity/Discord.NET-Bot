using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DiscordBot
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public Startup(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddYamlFile("_config.yml");
            Configuration = builder.Build();
        }

        public static async Task RunAsync(string[] args)
        {
            var startup = new Startup(args);
            await startup.StartAsync();
    }
}
