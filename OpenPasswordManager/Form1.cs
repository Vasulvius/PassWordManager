using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenPasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("youtube");
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("facebook");
        }

        private void google_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("google");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                notifyIcon1.Icon = null;
                notifyIcon1.Dispose();
                Environment.Exit(0);
            }
        }
    }
}
