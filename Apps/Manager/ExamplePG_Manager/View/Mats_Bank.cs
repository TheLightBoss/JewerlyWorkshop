using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePG_Manager.View
{
    class Mats_Bank
    {
        public Mats_Bank() { }
        public Mats_Bank(string Name, double Price, string Name_Bank, string url)
        {
            this.Name = Name;
            this.Name_Bank = Name_Bank;
            this.Price = Price;
            this.URL = url;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string URL { get; set; }
        public string Name_Bank { get; set; }
    }
}
