using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TourManagement.DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public static TourContext dbcontext;
        public GenericRepository()
        {
            dbcontext = new TourContext();
        }

        public int Delete(T entity)
        {
            dbcontext.Set<T>().Attach(entity);
            dbcontext.Set<T>().Remove(entity);
            return dbcontext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbcontext.Set<T>()
                    .ToList();
        }

        public T GetById(int id)
        {
            return dbcontext.Set<T>()
                    .Find(id);
        }

        public T Insert(T entity)
        {
            dbcontext.Set<T>().Add(entity);
            dbcontext.SaveChanges();
            return entity;
        }

        public int Update(T entity)
        {
            dbcontext.Set<T>().Attach(entity);
            dbcontext.Entry(entity).State = EntityState.Modified;
            return dbcontext.SaveChanges();
        }
    }
}
