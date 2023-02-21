using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsDnevnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void odeljenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odeljenje f1 = new Odeljenje();
            f1.Show();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba f2 = new Osoba();
            f2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
