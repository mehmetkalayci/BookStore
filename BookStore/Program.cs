using BookStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Db.Products.Add(new Book() { ItemId = 1, ItemName = "Social Animal", Author = "David Brooks", ISBN = "0486411087", Publisher = "NPR", ReleaseDate = new DateTime(2012,01,01) });
            Db.Products.Add(new Book() { ItemId = 2, ItemName = "Life of Pi", Author = "Yann Martel", ISBN = "05632321231", Publisher = "Random House of Canada", ReleaseDate = new DateTime(2012,01,01) });
            Db.Products.Add(new Book() { ItemId = 3, ItemName = "Twilight", Author = "Stephenie Meyer", ISBN = "1235654665", Publisher = "Penguin", ReleaseDate = new DateTime(2012, 01, 01) });
            Db.Products.Add(new Book() { ItemId = 4, ItemName = "Pride and Prejudice", Author = "Jane Austen", ISBN = "89746546", Publisher = "Dover Pub.", ReleaseDate = new DateTime(2012, 01, 01) });
            Db.Products.Add(new Book() { ItemId = 5, ItemName = "The Last Lecture", Author = "Randy Pausch, Jeffrey Zaslow", ISBN = "5554631213", Publisher = "NY Times", ReleaseDate = new DateTime(2012, 01, 01) });


            Db.Products.Add(new Music() { ItemId = 1, ItemName = "22", Publisher = "-", ReleaseDate = new DateTime(2014, 01, 01), AlbumName = "22", Artist = "Taylor Swift" });
            Db.Products.Add(new Music() { ItemId = 2, ItemName = "Thriller", Publisher = "MOTION PICTURE CAST RECORDING", ReleaseDate = new DateTime(1982, 01, 01), AlbumName = "Thriller", Artist = "Michael Jackson	" });
            Db.Products.Add(new Music() { ItemId = 3, ItemName = "The Dark Side of the Moon", Publisher = "-", ReleaseDate = new DateTime(1973, 01, 01), AlbumName = "The Dark Side of the Moon", Artist = "Pink Floyd" });
            Db.Products.Add(new Music() { ItemId = 4, ItemName = "Hello", Publisher = "-", ReleaseDate = new DateTime(2012, 01, 01), AlbumName = "25", Artist = "Adele" });
            Db.Products.Add(new Music() { ItemId = 5, ItemName = "Hybrid Theory", Publisher = "-", ReleaseDate = new DateTime(2012, 01, 01), AlbumName = "Hybrid Theory", Artist = "Linkin Park" });

            Db.Products.Add(new Movie() { ItemId = 1, ItemName = "In The Heart of the Sea", Publisher = "Sony Pics.", ReleaseDate = new DateTime(2016, 01, 01), IsSubtitled = true });
            Db.Products.Add(new Movie() { ItemId = 2, ItemName = "Esaretin Bedeli", Publisher = "", ReleaseDate = new DateTime(2094, 01, 01), IsSubtitled = false });
            Db.Products.Add(new Movie() { ItemId = 3, ItemName = "The Shawshank Redemption", Publisher = "", ReleaseDate = new DateTime(2094, 01, 01), IsSubtitled = true });
            Db.Products.Add(new Movie() { ItemId = 4, ItemName = "Batman", Publisher = "", ReleaseDate = new DateTime(2016, 01, 01), IsSubtitled = false });
            Db.Products.Add(new Movie() { ItemId = 5, ItemName = "Matrix", Publisher = "", ReleaseDate = new DateTime(1994, 01, 01), IsSubtitled = true });



            Db.Customers.Add(new Customer() { CustomerId = 1, FullName = "Hızlı Giriş", Email = "aaa", Password = "123", ShippingAddress = "Konya" });
            Db.Customers.Add(new Customer() { CustomerId = 2, FullName = "Mehmet Kalaycı", Email = "mmtkalayci@hotmail.com", Password = "123", ShippingAddress = "Konya" });
            Db.Customers.Add(new Customer() { CustomerId = 3, FullName = "Vehbi Bircan", Email = "vehbibircan@hotmail.com", Password = "abc", ShippingAddress = "Konya" });

            Db.Orders.Add(new Classes.Order()
            {
                OrderId = 1,
                CustomerId = 1,
                MethodOfPayment = PaymentType.CreditCard,
                ShippingFee = 10,
                Total = 10M,
                TransactionTime = new DateTime(2017,1,15),
                Items = new List<Item>() { Db.Products[0] }
            });

            Db.Orders.Add(new Classes.Order()
            {
                OrderId = 2,
                CustomerId = 2,
                MethodOfPayment = PaymentType.Cash,
                ShippingFee = 10,
                Total = 213.9M,
                TransactionTime = new DateTime(2017, 1, 21),
                Items = new List<Item>() {
                    Db.Products[0],
                    Db.Products[1],
                    Db.Products[2],
                    Db.Products[3]
                }
            });

            Db.Orders.Add(new Classes.Order()
            {
                OrderId = 3,
                CustomerId = 3,
                MethodOfPayment = PaymentType.Cash,
                ShippingFee = 10,
                Total = 55.59M,
                TransactionTime = new DateTime(2017, 1, 18),
                Items = new List<Item>() {
                    Db.Products[0],
                    Db.Products[1]
                }
            });





            Application.Run(new frmLogin());
        }
    }
}
