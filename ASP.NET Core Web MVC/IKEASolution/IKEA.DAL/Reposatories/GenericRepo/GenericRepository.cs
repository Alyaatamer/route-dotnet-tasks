using IKEA.DAL.Contexts;
using IKEA.DAL.Models.Shared;

namespace IKEA.DAL.Reposatories.GenericRepo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<TEntity> GetAll(bool WithTracking = false)
        {
            if (!WithTracking)
            {
                return _context.Set<TEntity>().Where(e => e.IsDeleted!= true).AsNoTracking();
            }
            else
            {
                return _context.Set<TEntity>().Where(e => e.IsDeleted != true);
            }
        }
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public void Add(TEntity item)
        {
            _context.Set<TEntity>().Add(item);
        }
        public void Update(TEntity item)
        {
            _context.Set<TEntity>().Update(item);
        }
        public void Delete(int id)
        {
            _context.Set<TEntity>().Remove(GetById(id));
        }

        //public IEnumerable<TEntity> GetEnumerable()
        //{
        //    return _context.Set<TEntity>();
        //}

        //public IQueryable<TEntity> GetQueryable()
        //{
        //    return _context.Set<TEntity>();
        //}
    }
}
