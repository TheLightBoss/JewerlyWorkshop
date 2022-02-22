using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Views
{
    // для метода updateEmployee
    public class Empl_View
    {
        public int idd { get; set; }
        public string log { get; set; }
        public string passw { get; set; }
        public string passp { get; set; }
        public string address_new{ get; set; }
        public string fio_new{ get; set; }
        public int exp{ get; set; } 
        public bool is_deleted{ get; set; }
    }
}
