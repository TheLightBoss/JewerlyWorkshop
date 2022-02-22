using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NbrbAPI.Models
{
    public class BankIngotPrice
    {
        public DateTime Date { get; set; }
        public int MetalId { get; set; }
        public decimal Value { get; set; }
    }
}