using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SadarakDeptProject.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
