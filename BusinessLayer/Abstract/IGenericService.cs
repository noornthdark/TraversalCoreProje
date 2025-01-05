using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> //Concrete sınıfında tanımlanan methotların imzaları, Business katmanına gelmeden önce genericService den geçecek concrete gelecek
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();//
        T TGEtByID(int id);
    }
}
