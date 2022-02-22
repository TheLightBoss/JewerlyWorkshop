using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePG_Manager.Models
{
    public class Empls
    {
        public int id_empl { get; set; }
        public string fio { get; set; }
        public string address { get; set; }
        public string passport { get; set; }
        public int experience { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public bool is_deleted { get; set; }
    }
}
