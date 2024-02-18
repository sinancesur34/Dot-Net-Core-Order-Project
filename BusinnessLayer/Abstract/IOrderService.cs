using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {
        List<Order> GetList();
        void OrderAdd(Order Order);
        void OrderDelete(Order Order);
        void OrderUpdate(Order Order);
        Order GetByID(int id);
    }
}
