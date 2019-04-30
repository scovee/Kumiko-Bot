using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

using static KumikoV4.CommandHandler;
namespace KumikoV4.Commands
{
    public class Date : ModuleBase<SocketCommandContext>
    {
        [Command("date")]
        public async Task date()
        {
            EmbedBuilder Embed = new EmbedBuilder();
            string DateNow = DateTime.Now.ToString("dd-MM-yyyy");
            Embed.WithAuthor("~Kumiko~");
            Embed.WithColor(new Color(255, 127, 80));
            Embed.WithDescription("Today is:" + DateNow);
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
