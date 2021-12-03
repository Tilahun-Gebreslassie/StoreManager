using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Unit Price")]
        public float UnitPrice { get; set; }
    }
}
