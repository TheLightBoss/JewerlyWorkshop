using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NbrbAPI.Models
{
    public class Metal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameBel { get; set; }
        public string NameEng { get; set; }
    }
}