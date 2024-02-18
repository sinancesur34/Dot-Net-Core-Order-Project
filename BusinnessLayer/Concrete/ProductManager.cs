using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {

        EFProductFramework EFProductRepository;
        public ProductManager()
        {
            EFProductRepository = new EFProductFramework();
        }



        public ProductInfo GetByID(int id)
        {
            return EFProductRepository.GetByID(id);
        }

        public List<ProductInfo> GetList()
        {
           return EFProductRepository.GetListAll();
        }

        public void ProductAdd(ProductInfo Product)
        {
            EFProductRepository.Insert(Product);
        }

        public void ProductDelete(ProductInfo Product)
        {
            EFProductRepository.Delete(Product);
        }

        public void ProductUpdate(ProductInfo Product)
        {
            EFProductRepository.Update(Product);
        }
    }
}
