using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }
        public string? FoodName { get; set; }
        public float Price { get; set; }
    }
}
