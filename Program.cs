using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class Program
    {
        public static async Task Main(string[] args) => await Startup.RunAsync(args);
    }
}
