using ECommerce.Domain.Contracts.Specfications;
using ECommerce.Domain.Models;
using System.Linq.Expressions;

namespace ECommerce.Service.Specifications
{
    public abstract class BaseSpecifications<TEntity, TKey> : ISpecification<TEntity, TKey> 
        where TEntity : BaseEntity<TKey>
    {
        protected BaseSpecifications(Expression<Func<TEntity, bool>> _Criteria)
        {
            Criteria = _Criteria;
        }
        public Expression<Func<TEntity, bool>> Criteria {  get; private set; }

        public List<Expression<Func<TEntity, object>>> Includes { get; } = [];
        protected void AddIncludes(Expression<Func<TEntity, object>> IncludeExperssion)
        {
            Includes.Add(IncludeExperssion);
        }
    }
}
