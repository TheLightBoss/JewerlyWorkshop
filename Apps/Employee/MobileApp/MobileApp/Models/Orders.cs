using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    //для получения заказов на выполнение
    public class Orders
    {
        public int id_prod { get; set; }
        public int id_empl { get; set; }
        public int id_production { get; set; }
        public List<string> list_jobs { get; set; }
        public List<string> list_done_job { get; set; }
        public DateTime date_start { get; set; }
        public string name_prod { get; set; }
        public string url_pic { get; set; }
        public double size { get; set; }
        public double weight { get; set; }

        /*      public int Id_izd { get; set; }
                public string Name_izd { get; set; }
                public double Razmer { get; set; }
                public string[] Spisok_rabot { get; set; }
                public bool Status { get; set; }
                public bool Polu_status { get; set; }
                public string[] Vipoln_rabot { get; set; }
                public DateTime date_start { get; set; }
                public string Url_pic { get; set; }*/
    }
}
