namespace eCommerce.Core.IBaseRepositories
{
    public interface IAdd<XEntity> where XEntity : class, IEntity, new()
    {
        void Add(XEntity entity);
    }
}
