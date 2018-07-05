﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Dal.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetOne(string key);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Edit(TEntity entity);
        void Save();
    }
}