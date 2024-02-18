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
    public class DessertManager:IDessertService
    {

        EFDessertFramework EFDessertRepository;
        public DessertManager()
        {
            EFDessertRepository = new EFDessertFramework();
        }



        public Dessert GetByID(int id)
        {
            return EFDessertRepository.GetByID(id);
        }

        public List<Dessert> GetList()
        {
            return EFDessertRepository.GetListAll();
        }

        public void DessertAdd(Dessert Dessert)
        {
            EFDessertRepository.Insert(Dessert);
        }

        public void DessertDelete(Dessert Dessert)
        {
            EFDessertRepository.Delete(Dessert);
        }

        public void DessertUpdate(Dessert Dessert)
        {
            EFDessertRepository.Update(Dessert);
        }
    }
}
