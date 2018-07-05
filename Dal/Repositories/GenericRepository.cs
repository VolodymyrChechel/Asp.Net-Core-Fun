using System;
using System.Linq;
using System.Linq.Expressions;
using Dal.Ef;
using Dal.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dal.Repositories
{
    public class GenericRepository <TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly VictimContext _context;

        public GenericRepository(VictimContext context)
        {
            _context = context;
        }

        public TEntity GetOne(string key)
        {
            return GetDbSet().Find(key);
        }

        public IQueryable<TEntity> GetAll()
        {
            return GetDbSet();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return GetDbSet().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            GetDbSet().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            GetDbSet().Remove(entity);
        }

        public void Edit(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private DbSet<TEntity> GetDbSet()
        {
            return _context.Set<TEntity>();
        }
    }
}