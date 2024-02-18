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
    public class MenuManager:IMenuService
    {
         EFMenuFramework EFMenuRepository;
        public MenuManager()
        {
            EFMenuRepository = new EFMenuFramework();
        }



        public Menu GetByID(int id)
        {
            return EFMenuRepository.GetByID(id);
        }

        public List<Menu> GetList()
        {
           return EFMenuRepository.GetListAll();
        }

        public void MenuAdd(Menu Menu)
        {
            EFMenuRepository.Insert(Menu);
        }

        public void MenuDelete(Menu Menu)
        {
            EFMenuRepository.Delete(Menu);
        }

        public void MenuUpdate(Menu Menu)
        {
            EFMenuRepository.Update(Menu);
        }
    }
}
