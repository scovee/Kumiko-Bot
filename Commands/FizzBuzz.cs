using Discord.Commands;
using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static KumikoV4.CommandHandler;
namespace Kasaibot.Modules
{
    public class FizzBuzzFunction : ModuleBase<SocketCommandContext>
    {
        Random rng;
        [Command("fizzbuzz")]
        public async Task roll(int message, int message2)
        {
            int min = message;
            int max = message2;

            for (int i = min; min <= max; min++)
            {
                if (min % 15 == 0)
                {
                    await Context.Channel.SendMessageAsync("FizzBuzz");
                }
                else if (min % 3 == 0)
                {
                    await Context.Channel.SendMessageAsync("Fizz");
                }
                else if (min % 5 == 0)
                {
                    await Context.Channel.SendMessageAsync("Buzz");
                }
                else
                {
                    await Context.Channel.SendMessageAsync(min.ToString());
                }
            }           
        }

    }
}