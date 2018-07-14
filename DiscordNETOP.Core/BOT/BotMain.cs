using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.EventArgs;
using DSharpPlus.Exceptions;

namespace DiscordNETOP.Core.BOT
{
    class BotMain
    {
        private DiscordClient client;

        public BotMain(int clientid, string token)
        {
            var cfg = new DiscordConfiguration
            {
                Token = token,
                TokenType = TokenType.Bot,

                AutoReconnect = true,
                LogLevel = LogLevel.Info,
                UseInternalLogHandler = true
            };
            client = new DiscordClient(cfg);
        }

        public async Task Run()
        {
            await client.ConnectAsync();
        }
    }
}
