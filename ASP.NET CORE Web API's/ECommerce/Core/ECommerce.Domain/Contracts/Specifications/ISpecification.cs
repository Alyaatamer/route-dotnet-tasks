using ECommerce.Domain.Models;
using System.Linq.Expressions;


namespace ECommerce.Domain.Contracts.Specfications
{
    public interface ISpecification<TEntity , TKey> where TEntity : BaseEntity<TKey>
    {
        Expression<Func<TEntity, bool>> Criteria { get; } //where 

        List<Expression<Func<TEntity,Object>>> Includes { get; } //Includes
    }
}
