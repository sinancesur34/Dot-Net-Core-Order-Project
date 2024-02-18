using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<ProductInfo> GetList();
        void ProductAdd(ProductInfo Product);
        void ProductDelete(ProductInfo Product);
        void ProductUpdate(ProductInfo Product);
        ProductInfo GetByID(int id);
    }
}
