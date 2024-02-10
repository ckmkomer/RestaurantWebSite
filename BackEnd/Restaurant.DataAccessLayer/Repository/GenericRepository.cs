using Microsoft.EntityFrameworkCore;
using Restaurant.CoreLayer.DataAccessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using System.Diagnostics;
using System.Linq.Expressions;




namespace Restaurant.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }



        public virtual void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
