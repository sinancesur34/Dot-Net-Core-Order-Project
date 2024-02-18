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
    public class OrderManager : IOrderService
    {


        EFOrderFramework EFOrderRepository;
        public OrderManager()
        {
            EFOrderRepository = new EFOrderFramework();
        }

        public Order GetByID(int id)
        {
            return EFOrderRepository.GetByID(id);
        }

        public List<Order> GetList()
        {
            return EFOrderRepository.GetListAll();
        }

        public void OrderAdd(Order Order)
        {
            EFOrderRepository.Insert(Order);
        }

        public void OrderDelete(Order Order)
        {
            EFOrderRepository.Delete(Order);
        }

        public void OrderUpdate(Order Order)
        {
           EFOrderRepository.Update(Order);
        }
    }
}
