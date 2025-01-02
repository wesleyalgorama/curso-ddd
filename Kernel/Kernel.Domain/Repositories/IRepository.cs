namespace Kernel.Domain.Repositories;

using Kernel.Domain.Model.Entities;
using System.Threading.Tasks;

public interface IRepository<T> : IQueryRepository<T>
    where T : class, IAggregateRoot
{
    Task Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
}
