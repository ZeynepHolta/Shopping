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
    public class ProductController : IProductService
    {
        private ShoppingFactory shoppingFactory;
        private ProductRepository _productRepository;

        public ProductController()
        {
            shoppingFactory = new ShoppingFactory();
            _productRepository = new ProductRepository();
        }

        public void Add(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Product product = _productRepository.Get(a => a.ProductId == entityID);
            _productRepository.Delete(product);
        }

        public Product Get(int entityID)
        {
            return _productRepository.Get(a => a.ProductId == entityID);
        }

        public ICollection<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
