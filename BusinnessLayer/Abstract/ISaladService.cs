using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISaladService
    {
        List<Salad> GetList();
        void SaladAdd(Salad Salad);
        void SaladDelete(Salad Salad);
        void SaladUpdate(Salad Salad);
        Salad GetByID(int id);
    }
}
