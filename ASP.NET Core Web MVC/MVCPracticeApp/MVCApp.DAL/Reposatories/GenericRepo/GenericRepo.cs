using Microsoft.EntityFrameworkCore;
using MVCApp.DAL.Contexts;
using MVCApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Reposatories.GenericRepo
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<TEntity> GetAll(bool WithTracking = false)
        {
            if (!WithTracking)
            {
                return _context.Set<TEntity>().Where(e => e.IsDeleted != true).AsNoTracking();
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
