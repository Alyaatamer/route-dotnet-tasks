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
        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (!WithTracking)
            {
                return _context.Set<TEntity>().AsNoTracking().ToList();
            }
            else
            {
                return _context.Set<TEntity>().ToList();
            }
        }
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public int Add(TEntity item)
        {
            _context.Set<TEntity>().Add(item);
            return _context.SaveChanges();
        }
        public int Update(TEntity item)
        {
            _context.Set<TEntity>().Update(item);
            return _context.SaveChanges();
        }
        public int Delete(int id)
        {
            _context.Set<TEntity>().Remove(GetById(id));
            return _context.SaveChanges();
        }
    }
}
