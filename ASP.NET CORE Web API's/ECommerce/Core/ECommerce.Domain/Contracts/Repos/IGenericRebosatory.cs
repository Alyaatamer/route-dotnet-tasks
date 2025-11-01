using ECommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Contracts.Repos
{
    public interface IGenericRebosatory<TEntity , TKey> where TEntity : BaseEntity<TKey>
    {
       public Task<IEnumerable<TEntity>> GetAllAsync(); 
       public Task<TEntity> GetByIdAsync(TKey id);
       public void Add(TEntity entity);
       public void Update(TEntity entity);
       public void Delete(TEntity entity);
    }
}
