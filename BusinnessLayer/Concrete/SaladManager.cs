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
    public class SaladManager : ISaladService
    {

        EFSaladFramework EFSaladRepository;
        public SaladManager()
        {
            EFSaladRepository = new EFSaladFramework();
        }



        public Salad GetByID(int id)
        {
            return EFSaladRepository.GetByID(id);
        }

        public List<Salad> GetList()
        {
            return EFSaladRepository.GetListAll();
        }

        public void SaladAdd(Salad Salad)
        {
            EFSaladRepository.Insert(Salad);
        }

        public void SaladDelete(Salad Salad)
        {
            EFSaladRepository.Delete(Salad);
        }

        public void SaladUpdate(Salad Salad)
        {
            EFSaladRepository.Update(Salad);
        }
    }
}
