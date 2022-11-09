using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Application.Abstracts;
using Tlp.ShoppingList.Domain;
using Tlp.ShoppingList.Domain.Common;

namespace Tlp.ShoppingList.Persistence.Concretes
{
    internal class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;
        private readonly IClaims claims;

        public Repository(DbContext dbContext,IMapper mapper,IClaims claims)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.claims = claims;
        }
        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.IsActive = false;
            Update(entity);
        }

        public Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().SingleOrDefaultAsync(f => f.Id == id, cancellationToken);
        }

        public Task<T> Get(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().SingleOrDefaultAsync(predicate, cancellationToken);
        }

        public Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().Where(predicate).ToListAsync(cancellationToken);
        }

        public Task<List<TDto>> GetAll<TDto>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {//mapper projesini ekle
            return dbContext.Set<T>().Where(predicate).ProjectTo<TDto>(mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
        public Task<List<TDto>> GetAll<TDto>(Expression<Func<T, bool>> predicate, Expression<Func<TDto, object>> order, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().Where(predicate).ProjectTo<TDto>(mapper.ConfigurationProvider).OrderBy(order).ToListAsync(cancellationToken);
        }
        public void Insert(T entity)
        {
            entity.IsActive = true;
            entity.IsDeleted = false;
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
            if (claims.IsAuthenticated) //claim authenticated olduysa aşağıdaki bilgileri setle
            {
                entity.CreatedBy = claims.CurrentUser.Id;
                entity.ModifiedBy = claims.CurrentUser.Id;
            }
            dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            entity.ModifiedAt = DateTime.Now;
            //if (claims.IsAuthenticated)
            //{
            //    entity.ModifiedBy = claims.CurrentUser.Id;
            //}
            dbContext.Set<T>().Update(entity);
        }
    }
}
