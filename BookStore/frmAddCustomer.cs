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
    public partial class frmAddCustomer : BaseForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void ClearComponents()
        {
            txtMusteriId.Text = txtFullName.Text = txtEmail.Text = txtPassword.Text = txtShippingAddress.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.CustomerId = int.Parse(txtMusteriId.Text);
            customer.FullName = txtFullName.Text;
            customer.Email = txtEmail.Text;
            customer.Password = txtPassword.Text;
            customer.ShippingAddress = txtShippingAddress.Text;
            

            Db.Customers.Add(customer);
            MessageBox.Show("Müşteri Eklendi!");
            ClearComponents();
        }
    }
}
