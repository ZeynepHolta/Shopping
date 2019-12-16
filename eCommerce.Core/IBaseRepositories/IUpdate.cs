namespace eCommerce.Core.IBaseRepositories
{
    public interface IUpdate<XEntity> where XEntity : class, IEntity, new()
    {
        void Update(XEntity entity);
    }
}
