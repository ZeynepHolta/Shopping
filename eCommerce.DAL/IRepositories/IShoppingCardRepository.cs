using eCommerce.Core.IBaseRepositories;

namespace eCommerce.DAL.IRepositories
{
    public interface IShoppingCardRepository : IAdd<ShoppingCard>
                                             , IGet<ShoppingCard>
                                             , IGetAll<ShoppingCard>
                                             , ISave
                                             , IDelete<ShoppingCard>
                                             , IUpdate<ShoppingCard>
    {
    }
}
