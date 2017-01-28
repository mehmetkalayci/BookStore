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
    public partial class frmCustomers : BaseForm
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void ClearComponents()
        {
            txtMusteriId.Text = txtFullName.Text = txtEmail.Text = txtPassword.Text = txtShippingAddress.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer tempCustomer = (Customer)dgView.CurrentRow.DataBoundItem;

                tempCustomer.CustomerId = int.Parse(txtMusteriId.Text);
                tempCustomer.FullName = txtFullName.Text;
                tempCustomer.Email = txtEmail.Text;
                tempCustomer.Password = txtPassword.Text;
                tempCustomer.ShippingAddress = txtShippingAddress.Text;

                MessageBox.Show("Veriler Güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!\n" + ex.Message);
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            dgView.DataSource = Db.Customers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kayıt Silinsin Mi?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Customer selectedCustomer = (Customer)dgView.CurrentRow.DataBoundItem;
                    Db.Customers.Remove(selectedCustomer);

                    dgView.DataSource = null;
                    dgView.DataSource = Db.Customers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!\n" + ex.Message);
                throw;
            }
        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ClearComponents();


                txtMusteriId.Text = dgView.CurrentRow.Cells[0].Value.ToString();
                txtFullName.Text = dgView.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = dgView.CurrentRow.Cells[2].Value.ToString();
                txtPassword.Text = dgView.CurrentRow.Cells[3].Value.ToString();
                txtShippingAddress.Text = dgView.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
