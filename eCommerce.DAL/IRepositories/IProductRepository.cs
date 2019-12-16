using eCommerce.Core.IBaseRepositories;

namespace eCommerce.DAL.IRepositories
{
    public interface IProductRepository : IAdd<Product>
                                        , IGet<Product>
                                        , IGetAll<Product>
                                        , ISave
                                        , IDelete<Product>
                                        , IUpdate<Product>
    {
    }
}
