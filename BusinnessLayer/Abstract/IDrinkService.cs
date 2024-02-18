using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDrinkService
    {
        List<Drink> GetList();
        void DrinkAdd(Drink Drink);
        void DrinkDelete(Drink Drink);
        void DrinkUpdate(Drink Drink);
        Drink GetByID(int id);
    }
}
