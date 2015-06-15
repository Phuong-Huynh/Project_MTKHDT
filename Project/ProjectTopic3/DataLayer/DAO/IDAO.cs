using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    public interface IDAO<T>
    {
        T get(int id);
        bool insert(T t);
        bool delete(int id);
        bool update(T t);
        List<T> getList();
    }
}
