using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Drink
    {
        [Key]
        public int DrinkID { get; set; }
        public string? DrinkName { get; set; }
        public float Price { get; set; }
    
    }
}
