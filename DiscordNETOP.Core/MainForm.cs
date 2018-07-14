using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordNETOP.Core
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e) => Close();

        private void login_ClickAsync(object sender, EventArgs e)
        {
            int xcid;
            if (int.TryParse(flatTextBox2.Text, out xcid))
            {
                Hide();
                var bot = new BOT.BotMain(xcid, flatTextBox1.Text);
                bot.Run().Start();
            } else
            {

            }
        }
    }
}
