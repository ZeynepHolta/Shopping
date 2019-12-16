using eCommerce.BLL.Abstract;
using eCommerce.DAL.Repository;
using eCommerce.DAL.Repository.EntityFrameworkRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL.Concrete
{
    public class OrderController : IOrderService
    {
        private ShoppingFactory shoppingFactory;
        private OrderRepository _orderRepository;

        public OrderController()
        {
            shoppingFactory = new ShoppingFactory();
            _orderRepository = new OrderRepository();
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int entityID)
        {
            throw new NotImplementedException();
        }

        public Order Get(int entityID)
        {
            return _orderRepository.Get(a => a.OrderId == entityID);
        }

        public ICollection<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
