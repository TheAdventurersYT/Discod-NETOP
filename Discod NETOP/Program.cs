using System;
using DiscordNETOP.Core;

namespace DiscordNETOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new NETOP().Main();
        }
    }
}
