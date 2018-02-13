using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourNameHere
{
    public partial class YourNameHere_Form : Form
    {
        public YourNameHere_Form()
        {
            InitializeComponent();
            Definitions.Lettere test = new Definitions.Lettere();
            test.Color = "black";
            test.Letters = "aeiou";
            test.NumPad = false;
            lettereBindingSource.Add(test);
        }

        private void ynhNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ynhNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.Show();
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
