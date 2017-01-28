using BookStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Db
    {
        public static List<Item> Products = new List<Item>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Order> Orders = new List<Order>();
    }
}
