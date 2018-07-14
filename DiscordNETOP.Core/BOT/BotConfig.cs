using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordNETOP.Core.BOT
{
    class BotConfig
    {
        private static Dictionary<string, string> alerts;

        static BotConfig()
        {
            string json = File.ReadAllText("Assets\\botconfig.json");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(json);
            alerts = data.ToObject<Dictionary<string, string>>();
        }

        public static string GetItem(ConfigItem key)
        {
            string key2 = "";
            if (alerts.ContainsKey(key2)) return alerts[key2];
            return "";

        }
    }

    enum ConfigItem
    {
        CLIENT_ID,
        TOKEN,

    }
}
