using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePG_Manager.Models
{
    public class Masters
    {
        public Masters() { }
        public Masters(int IdMaster, string Fio, string Address, string Passport, short Stag, string Login, string Password)
        {
            this.IdMaster = IdMaster;
            this.Login = Login;
            this.Passport = Passport;
            this.Password = Password;
            this.Stag = Stag;
            this.Address = Address;
            this.Fio = Fio;
        }

        public int IdMaster { get; set; }
        public string Fio { get; set; }
        public string Address { get; set; }
        public string Passport { get; set; }
        public short Stag { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
