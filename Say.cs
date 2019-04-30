using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

using static KumikoV4.CommandHandler;
namespace KumikoV4.Commands
{
    public class sayMod : ModuleBase<SocketCommandContext>
    {
        [Command("say")]
        public async Task say([Remainder]string message)
        {
            await Context.Channel.SendMessageAsync(message);
            await Context.Message.DeleteAsync();
        }
    }
}
