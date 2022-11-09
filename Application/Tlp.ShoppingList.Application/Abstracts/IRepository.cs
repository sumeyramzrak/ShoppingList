using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Domain;

namespace Tlp.ShoppingList.Application.Abstracts
{
    public interface IRepository<T> where T: EntityBase
    {
        Task<T> Get(Guid id, CancellationToken cancellationToken); // id ile ilgili T'yi dönsün
        Task<T> Get(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken); //predicate e dayanan bir filtre ile T dönsün
        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken); //Bir filtreye bağlı tümünü dönsün.
        Task<List<TDto>> GetAll<TDto>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken); //mapper ile bir list<dto> dönsün
        Task<List<TDto>> GetAll<TDto>(Expression<Func<T, bool>> predicate, Expression<Func<TDto, object>> order, CancellationToken cancellationToken);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
