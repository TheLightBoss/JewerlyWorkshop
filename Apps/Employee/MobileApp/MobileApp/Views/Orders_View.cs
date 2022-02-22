using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Views
{
    //для updateProduction
    public class Orders_View
    {
        public int id_production { get; set; }
        public List<string> list_done { get; set; }
        public bool status { get; set; }
        public bool half_status { get; set; }
        //id_production, list_done, status, half_status
    }
}
