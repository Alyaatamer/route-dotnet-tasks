using IKEA.DAL.Models.Shared;

namespace IKEA.DAL.Reposatories.GenericRepo
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> GetAll(bool WithTracking = false);
        public TEntity GetById(int id);
        public int Add(TEntity item);
        public int Update(TEntity item);
        public int Delete(int id);
    }
}
