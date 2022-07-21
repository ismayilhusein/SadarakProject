using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SadarakDeptProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal BuyPrise { get; set; }
        public double SellPrise { get; set; }
        public decimal WayPrice { get; set; }
        public decimal Weight { get; set; }
        public bool isKg { get; set; }
        public bool isDollar { get; set; }
        public int Count { get; set; }
        public double PlusPrise { get; set; }
        public double Rate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public bool Status { get; set; }

        public List<Color> Colors { get; set; }
    }
}
