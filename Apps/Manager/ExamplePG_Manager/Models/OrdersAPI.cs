using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePG_Manager.Models
{
    public class OrdersAPI
    {
        public int id_order { get; set; }
        public DateTime date_order { get; set; }
        public bool status_order { get; set; }
        public bool is_deleted { get; set; }
        public int id_prod { get; set; }
        public string price_prod { get; set; }
        public string name_prod { get; set; }
        public string fio { get; set; }
        public string contact_face { get; set; }
        public object id_empl { get; set; }
    }
}
