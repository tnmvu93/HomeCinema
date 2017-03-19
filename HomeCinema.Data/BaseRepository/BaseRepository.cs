using System;
using HomeCinema.Data.Entities;
using HomeCinema.Data;
using System.Linq;
using System.Data.Entity;

namespace HomeCinema.Data.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        #region properties
        protected HomeCinemaContext dbContext;

        public BaseRepository(HomeCinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region methods
        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void Add(T entity)
        {
            var dbEntityEntry = dbContext.Entry<T>(entity);
            dbContext.Set<T>().Add(entity);
        }

        public void Edit(T entity)
        {
            var dbEntityEntry = dbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            var dbEntityEntry = dbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }
        #endregion
    }
}
