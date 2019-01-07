using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void müsterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 customer = new Form1();
            customer.MdiParent = this;
            customer.Show();
        }

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.MdiParent = this;
            urunler.Show();

        }
    }
}
