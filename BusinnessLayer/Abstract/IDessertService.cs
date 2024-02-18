using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDessertService
    {
        List<Dessert> GetList();
        void DessertAdd(Dessert Dessert);
        void DessertDelete(Dessert Dessert);
        void DessertUpdate(Dessert Dessert);
        Dessert GetByID(int id);
    }
}
