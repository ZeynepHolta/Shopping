namespace eCommerce.Core.IBaseRepositories
{
    public interface IDelete<XEntity> where XEntity : class, IEntity, new()
    {
        void Delete(XEntity entity);
    }
}
