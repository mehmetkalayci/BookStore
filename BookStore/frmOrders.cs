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
    public partial class frmOrders : BaseForm
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void ClearComponents()
        {
            txtEmail.Text = txtFullName.Text = txtMusteriId.Text = txtOrderId.Text = txtPaymentType.Text = txtShippingAddress.Text = txtShippingFee.Text = txtTotal.Text = txtTransactionDate.Text = "";
            lstProducts.Items.Clear();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            dgView.DataSource = Db.Orders;
        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ClearComponents();

                Order tempOrder = (Order)dgView.CurrentRow.DataBoundItem;

                object data = Db.Customers.Where(x => x.CustomerId == tempOrder.CustomerId).FirstOrDefault();
                if (data != null)
                {
                    Customer tempCustomer = (data as Customer);
                    txtMusteriId.Text = tempCustomer.CustomerId.ToString();
                    txtFullName.Text = tempCustomer.FullName;
                    txtEmail.Text = tempCustomer.Email;
                    txtShippingAddress.Text = tempCustomer.ShippingAddress;
                }

                txtOrderId.Text = tempOrder.OrderId.ToString();
                txtShippingFee.Text = tempOrder.ShippingFee.ToString("c");
                txtTotal.Text = tempOrder.Total.ToString("c");
                txtTransactionDate.Text = tempOrder.TransactionTime.ToString();
                txtPaymentType.Text = tempOrder.MethodOfPayment.ToString();

                lstProducts.Items.AddRange(tempOrder.Items.ToArray());
                lstProducts.DisplayMember = "ItemName";

            }
            catch (Exception ex)
            {
            }
        }
    }
}
