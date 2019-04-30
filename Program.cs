using Discord.WebSocket;
using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using KumikoV4.WebAPI;

namespace KumikoV4
{
    public class Program
    {
        static void Main(string[] args)
       => new Program().StartAsync().GetAwaiter().GetResult();
        private DiscordSocketClient _client;
        public async Task StartAsync()
        {
            _client = new DiscordSocketClient(new DiscordSocketConfig { LogLevel = LogSeverity.Verbose });
            new CommandHandler(_client);
            await _client.LoginAsync(Discord.TokenType.Bot, "NTU2MTI4MjcyOTU0NTU2NDE2.XL7aCg.6r0zN5OOSBbbCQbsJuAPL3mn1Q0");
            await _client.StartAsync();
            await Task.Delay(-1);
            
        }
    }
}
