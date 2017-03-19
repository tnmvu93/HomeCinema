using HomeCinema.Data.Entities;
using System.Linq;

namespace HomeCinema.Data.BaseRepository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
