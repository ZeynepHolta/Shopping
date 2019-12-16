using eCommerce.Core;
using System.Collections.Generic;

namespace eCommerce.BLL.Abstract
{
    public interface IServiceBase<T>
        where T : IEntity
    {
        void Add(T entity);

        T Get(int entityID);

        void Update(T entity);

        ICollection<T> GetAll();

        void Delete(T entity);

        void DeleteById(int entityID);
    }
}
