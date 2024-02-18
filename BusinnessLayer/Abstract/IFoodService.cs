using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFoodService
    {
        List<Food> GetList();
        void FoodAdd(Food Food);
        void FoodDelete(Food Food);
        void FoodUpdate(Food Food);
        Food GetByID(int id);
    }
}
