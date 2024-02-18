using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductInfo 
    {
        [Key]
        public int ProductInfoID { get; set; }
        public int? OrderID { get; set; }

        
        public EnmProductType EnmProductType { get; set; }
        //public int ProductID { get; set; }
        public int Piece { get; set; }

        public int ProductPrice { get; set; }
        public EnmProductSize EnmProductSize { get; set; }

    }
}
