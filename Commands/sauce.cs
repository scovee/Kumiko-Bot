using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

using static KumikoV4.CommandHandler;
namespace KumikoV4.Commands
{
    public class sauce : ModuleBase<SocketCommandContext>
    {
        [Command("sauce")]
        public async Task source([Remainder]string numbers)
        {
            string sauce = @"http://nhentai/g/" + numbers + "/";
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("~Kumiko~");
            Embed.WithColor(new Color(255, 127, 80));
            Embed.WithDescription("Here comes the marinara");
            Embed.WithUrl(sauce);
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
