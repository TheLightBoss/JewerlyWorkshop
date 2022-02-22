using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Data
{
    public class OrderSOAP
    {
        public int id_client { get; set; }
        public DateTime date_order { get; set; }
        public bool status_order { get; set; }
        public string price_prod { get; set; }
        public double weight { get; set; }
        public double size_prod { get; set; }
        public string name_prod { get; set; }
        public string url_pic { get; set; }
        public bool is_deleted { get; set; }
    }
    public class CreateOrder
    {
        public int id_ref_prod { get; set; }
        public int id_client { get; set; }
        public double size { get; set; }
        public double weight { get; set; }
        public double price_prod { get; set; }
    }
    public class ClientSOAP //[login_n, passw, fio_new, req, address_new, contactface]);
    {
        public int id_client { get; set; }
        public string login { get; set; }
        public string password_hash { get; set; }//login, password_hash, fio, requisites, address_live, contact_face
        public string fio { get; set; }
        public string requisites { get; set; }
        public string address_live { get; set; }
        public string contact_face { get; set; }
    }
}
