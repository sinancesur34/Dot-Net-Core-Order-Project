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
    public class FoodManager:IFoodService
    {

        EFFoodFramework EFFoodRepository;
        public FoodManager()
        {
            EFFoodRepository = new EFFoodFramework();
        }



        public Food GetByID(int id)
        {
            return EFFoodRepository.GetByID(id);
        }

        public List<Food> GetList()
        {
            return EFFoodRepository.GetListAll();
        }

        public void FoodAdd(Food Food)
        {
            EFFoodRepository.Insert(Food);
        }

        public void FoodDelete(Food Food)
        {
            EFFoodRepository.Delete(Food);
        }

        public void FoodUpdate(Food Food)
        {
            EFFoodRepository.Update(Food);
        }
    }
}
