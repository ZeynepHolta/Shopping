using System;
using System.Linq.Expressions;

namespace eCommerce.Core.IBaseRepositories
{
    public interface IGet<XEntity> where XEntity : class, IEntity, new()
    {
        XEntity Get(Expression<Func<XEntity, bool>> filter);
    }
}
