using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsesLayer.Abstract;
using DataAccsesLayer.Concrete;

namespace DataAccsesLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class// IGenericDal Class tan method çektik
    {
        public void Delete(T t)
        {
            using var c = new Context();// Context class bir nesne yarattık
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
        }
    }
}
