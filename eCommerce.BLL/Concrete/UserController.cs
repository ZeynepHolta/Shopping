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
    public class UserController : IUserService
    {
        private ShoppingFactory shoppingFactory;
        private UserRepository _userRepository;

        public UserController()
        {
            shoppingFactory = new ShoppingFactory();
            _userRepository = new UserRepository();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int entityID)
        {
            throw new NotImplementedException();
        }

        public User Get(int entityID)
        {
            return _userRepository.Get(a => a.UserId == entityID);
        }

        public ICollection<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User Login(string username, string password)
        {
            User user = _userRepository.Get(a => a.Username == username && a.Password == password);
            return user;
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
