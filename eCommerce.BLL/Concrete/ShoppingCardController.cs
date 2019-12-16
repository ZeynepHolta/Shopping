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
    public class ShoppingCardController : IShoppingCardService
    {
        private ShoppingFactory shoppingFactory;
        private ShoppingCardRepository _shoppingCardRepository;

        public ShoppingCardController()
        {
            shoppingFactory = new ShoppingFactory();
            _shoppingCardRepository = new ShoppingCardRepository();
        }

        public void Add(ShoppingCard entity)
        {
            _shoppingCardRepository.Add(entity);
        }

        public void Delete(ShoppingCard entity)
        {
            _shoppingCardRepository.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            ShoppingCard shoppingCard = _shoppingCardRepository.Get(a => a.ShoppingCardId == entityID);
            _shoppingCardRepository.Delete(shoppingCard);
        }

        public ShoppingCard Get(int entityID)
        {
            return _shoppingCardRepository.Get(a => a.ShoppingCardId == entityID);
        }

        public ICollection<ShoppingCard> GetAll()
        {
            return _shoppingCardRepository.GetAll();
        }

        public void Update(ShoppingCard entity)
        {
            _shoppingCardRepository.Update(entity);
        }
    }
}
