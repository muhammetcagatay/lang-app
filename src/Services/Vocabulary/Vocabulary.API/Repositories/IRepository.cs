using System.Linq.Expressions;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Repositories
{
    public interface IRepository <T> where T : IEntity
    {
        List<T> GetAll ();
        Task<List<T>> GetAllAsync ();
        T GetById (int id);
        Task<T> GetByIdAsync (int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        void Create(T entity);
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Commit();
        Task CommitAsync();
    }
}
