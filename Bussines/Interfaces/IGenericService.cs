using Entities.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task UpdateAsync(TEntity entity);
        Task AddAsync(TEntity entity);
        Task RemaoveAsync(TEntity entity);
    }
}
