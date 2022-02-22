using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePG_Manager.View
{
    public class Zakazs_Master
    {
        public int Id_izd { get; set; }
        public int Id_sotr { get; set; }
        public string Name_izd { get; set; }
        public double Razmer { get; set; }
        public string[] Spisok_rabot { get; set; }
        public bool Status { get; set; }
        public bool Polu_status { get; set; }
        public string[] Vipoln_rabot { get; set; }
        public DateTime date_start { get; set; }
        public string Url_pic { get; set; }
    }
}
