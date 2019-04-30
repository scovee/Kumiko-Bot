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
    public class rollFunction : ModuleBase<SocketCommandContext>
    {
        Random rng;
        [Command("roll")]
        public async Task roll(string message)
        {
            rng = new Random();
            string rollstring = Convert.ToString(rng);
            string msgval = message;
            int max;
            if (msgval == null)
            {
                max = 100;
            }
            else
            {
                max = Convert.ToInt32(message);
            }
            int rollvalint = rng.Next(max + 1);
            string rollval = rollvalint.ToString();
            string maxroll = max.ToString();
            await Context.Channel.SendMessageAsync(Context.Message.Author.Mention + " has rolled " + rollval + " out of " + maxroll);
        }

    }
}