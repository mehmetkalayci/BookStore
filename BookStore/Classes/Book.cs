using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Classes
{
    public class Book : Item
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
