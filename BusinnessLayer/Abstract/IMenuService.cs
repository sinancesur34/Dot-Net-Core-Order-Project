using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMenuService
    {
        List<Menu> GetList();
        void MenuAdd(Menu Menu);
        void MenuDelete(Menu Menu);
        void MenuUpdate(Menu Menu);
        Menu GetByID(int id);
    }
}
