using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gw2TacO_Dummy
{
    internal class TrayMenu : ContextMenuStrip
    {
        private NotifyIcon _trayIcon = null;

        public TrayMenu()
        {
            _trayIcon = new NotifyIcon
            {
                Text = "Gw2TacO - Dummy",
                Icon = Properties.Resources.Blish___Taco_Icon,
                ContextMenuStrip = this,
                Visible = true
            };

            Items.Add("Exit", null, OnExit);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
