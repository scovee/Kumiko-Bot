using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Timers;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static KumikoV4.CommandHandler;
namespace KumikoV4.Commands
{
    public class time : ModuleBase<SocketCommandContext>
    {
        [Command("time")]
        public async Task timeMod()
        {
            EmbedBuilder Embed = new EmbedBuilder();
            string TimeNow = DateTime.Now.ToString("hh:mm" + " " + "tt", CultureInfo.InvariantCulture);
            Embed.WithAuthor("~ Kumiko ~");
            Embed.WithColor(new Color(255, 127, 80));
            Embed.WithDescription("The time is: " + TimeNow);
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
