using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Domain.Contracts
{
    public interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetByIdAsync(int id);

        void Add(TEntity entity);

        Task AddAsync(TEntity entity);

        void Delete(TEntity entity);
    }
}
