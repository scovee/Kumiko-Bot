using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

using static KumikoV4.CommandHandler;
namespace KumikoV4.Commands
{
    public class Pick : ModuleBase<SocketCommandContext>
    {
        Random rng;
        [Command("choose")]
        public async Task pick([Remainder]string message1, string message2)
        {
            rng = new Random();
            string rollstring = Convert.ToString(rng);
            int max = 100;
            int rollval = rng.Next(max + 1);

            if(rollval < 50)
            {
                await Context.Channel.SendMessageAsync(Context.Message.Author.Mention + "I choose: " + message1);
            }

            if (rollval >= 50)
            {
                await Context.Channel.SendMessageAsync(Context.Message.Author.Mention + "I choose: " + message2);
            }

        }
    }
}
