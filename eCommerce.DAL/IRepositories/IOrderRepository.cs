using eCommerce.Core.IBaseRepositories;

namespace eCommerce.DAL.IRepositories
{
    public interface IOrderRepository : IGet<Order>
                                      , IGetAll<Order>
    {
    }
}
