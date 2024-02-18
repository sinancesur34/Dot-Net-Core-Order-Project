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
    public class DrinkManager : IDrinkService
    {

        EFDrinkFramework EFDrinkRepository;
        public DrinkManager()
        {
            EFDrinkRepository = new EFDrinkFramework();
        }



        public Drink GetByID(int id)
        {
            return EFDrinkRepository.GetByID(id);
        }

        public List<Drink> GetList()
        {
            return EFDrinkRepository.GetListAll();
        }

        public void DrinkAdd(Drink Drink)
        {
            EFDrinkRepository.Insert(Drink);
        }

        public void DrinkDelete(Drink Drink)
        {
            EFDrinkRepository.Delete(Drink);
        }

        public void DrinkUpdate(Drink Drink)
        {
            EFDrinkRepository.Update(Drink);
        }
    }
}