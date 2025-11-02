using ECommerce.Domain.Contracts.Specfications;
using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Persistence
{
    public static class SpecificationEvaluator
    {
        public static IQueryable<TEntity> CreateQuery<TEntity , TKey>(IQueryable<TEntity> BaseQuery, ISpecification<TEntity, TKey> specification) 
            where TEntity : BaseEntity<TKey>
        {
            var query = BaseQuery;
            // Apply criteria
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }
            // Apply includes
            if(specification.Includes != null && specification.Includes.Any())
            {
                query = specification.Includes.Aggregate(query, (CurrentQuery, Expression) => CurrentQuery.Include(Expression));
            }
            return query;
        }
    }
}
