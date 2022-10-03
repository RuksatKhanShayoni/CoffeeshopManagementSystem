using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class EProduct
    {
        public string UPASS { set; get; }
        public int SID { set; get; }
        public int Latte { set; get; }
        public int Cappuccino { set; get; }
        public int Mocha { set; get; }
        public int Americano { set; get; }
        public int Flatwhite { set; get; }
        public int Espresso { set; get; }

        public string Name { set; get; }
        public string Contact_No { set; get; }
        public string Email { set; get; }
        public string Date { set; get; }
        public int Price { set; get; }
        public string ID { set; get; }
        public string Admin { set; get; }
        public string Employees { set; get; }
        public string Pass { set; get; }
    }
}
