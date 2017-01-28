using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Classes
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<Item> Items { get; set; }
        public Decimal ShippingFee { get; set; }
        public Decimal Total { get; set; }
        public PaymentType MethodOfPayment { get; set; }
        public DateTime TransactionTime { get; set; }
    }

    public enum PaymentType
    {
        Cash = 0,
        CreditCard = 1,
        DebitCard = 2
    }
}
