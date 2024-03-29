﻿using Microsoft.EntityFrameworkCore;
using PTApi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PTApi.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public TEntity GetSharedAppEntity(int? id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public TEntity GetCompany(string companyId)
        {
            return Context.Set<TEntity>().Find(companyId);
        }

        public TEntity Get(string id, string companyId)
        {
            return Context.Set<TEntity>().Find(id, companyId);
        }


        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }


        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            Context.Update(entity);
        }



        // Here we are working with a DbContext, not ApplicationDbContext. So we don't have DbSets 
        // such as Courses or Authors, and we need to use the generic Set() method to access them.

        //public IEnumerable<TEntity> GetAll()
        //{
        //    // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
        //    // too much noise. I could get a reference to the DbSet returned from this method in the 
        //    // constructor and store it in a private field like _entities. This way, the implementation
        //    // of our methods would be cleaner:
        //    // 
        //    // _entities.ToList();
        //    // _entities.Where();
        //    // _entities.SingleOrDefault();
        //    // 
        //    // I didn't change it because I wanted the code to look like the videos. But feel free to change
        //    // this on your own.
        //    return Context.Set<TEntity>().ToList();
        //}
    }
}
