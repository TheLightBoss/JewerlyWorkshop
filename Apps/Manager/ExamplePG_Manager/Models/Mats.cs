using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePG_Manager.Models
{
    class Mats
    {
        public Mats() { }
        public Mats(int id, string name, double price, int id_b, string url)
        {
            ID = id;
            Name = name;
            Price = price;
            ID_Bank = id_b;
            URL = url;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public double Price { get; set; }
        public int ID_Bank { get; set; }
    }
}
