using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace eCommerce.Core.IBaseRepositories
{
    public interface IGetAll<XEntity> where XEntity : class, IEntity, new()
    {
        ICollection<XEntity> GetAll(Expression<Func<XEntity, bool>> filter = null);
    }
}
