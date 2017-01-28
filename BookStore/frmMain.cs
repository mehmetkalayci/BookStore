using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmMain : BaseForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProducts().ShowDialog();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddProduct().ShowDialog();
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCustomers().ShowDialog();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddCustomer().ShowDialog();
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmOrders().ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
