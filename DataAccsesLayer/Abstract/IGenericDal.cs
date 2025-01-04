using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsesLayer.Abstract
{
    public interface IGenericDal<T>// bütünü kapsayıcı T parametresi entitye(varlığa) karşılık gelecek.
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();

    }
}
