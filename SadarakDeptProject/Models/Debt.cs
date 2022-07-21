using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SadarakDeptProject.Models
{
    public class Debt
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Prise { get; set; }
        public bool isDollar { get; set; }
        [Required]
        [MaxLength(200)]
        public string Info { get; set; }
        public string MobileNo { get; set; }
        public string MobilNo2 { get; set; }
    }
}
