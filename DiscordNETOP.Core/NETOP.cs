using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordNETOP.Core
{
    public class NETOP
    {
        private Form MainForm;

        public NETOP()
        {
            MainForm = new MainForm();
        }

        public void Main()
        {
            MainForm.ShowDialog();
        }
    }
}
