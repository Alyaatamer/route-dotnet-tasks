using MVCApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Reposatories.GenericRepo
{
    public interface IGenericRepo<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> GetAll(bool WithTracking = false);
        public TEntity GetById(int id);
        public int Add(TEntity item);
        public int Update(TEntity item);
        public int Delete(int id);
    }
}
