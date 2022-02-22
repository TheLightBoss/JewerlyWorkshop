using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePG_Manager.Models
{
    public class OrdersRun
    {
        
        public int id_order { get; set; }
        public DateTime date_order { get; set; }
        public bool status_order { get; set; }
        public bool is_deleted { get; set; }
        public int id_prod { get; set; }
        public string price_prod { get; set; }
        public string fio { get; set; }
        public string contact_face { get; set; }
        public string name_prod { get; set; }
        public string url_pic { get; set; }
        public int id_empl { get; set; }
        public DateTime date_start { get; set; }
        public DateTime? date_end { get; set; }
        public bool half_status { get; set; }
        public bool status { get; set; }
    }
}
