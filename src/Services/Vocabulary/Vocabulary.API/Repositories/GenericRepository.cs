using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Vocabulary.API.Data;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly VocabularyDBContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(VocabularyDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            var entities = _dbSet.Where(x => !x.IsDelete).ToList();
            return entities;
        }
        public async Task<List<T>> GetAllAsync()
        {
            var entities = await _dbSet.Where(x => !x.IsDelete).ToListAsync();
            return entities;
        }
        public T GetById(int id)
        {
            var entity = _dbSet.Where(x => !x.IsDelete).FirstOrDefault(x => x.Id == id);
            return entity;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.Where(x => !x.IsDelete).FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(x => !x.IsDelete).Where(expression);
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }
        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
        public void Delete(T entity)
        {
            entity.IsDelete = true;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
