using BookStore.Classes;
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
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            object data = Db.Customers.Where(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (data != null)
            {
                MessageBox.Show("Hoşgeldin, " + (data as Customer).FullName);
                this.Hide();
                new frmMain().Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı/parola!");
            }
        }
    }
}
