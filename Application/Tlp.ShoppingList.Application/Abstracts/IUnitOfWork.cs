using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Domain;

namespace Tlp.ShoppingList.Application.Abstracts
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : EntityBase;
        Task<int> SaveChanges(CancellationToken cancellationToken);
    }
}
