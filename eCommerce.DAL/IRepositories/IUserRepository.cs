using eCommerce.Core.IBaseRepositories;

namespace eCommerce.DAL.IRepositories
{
    public interface IUserRepository : IGet<User>
                                     , IGetAll<User>
    {
    }
}
