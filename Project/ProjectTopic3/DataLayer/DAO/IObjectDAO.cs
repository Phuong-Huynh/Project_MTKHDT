using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    public interface IObjectDAO<T,DTO>
    {
        DTO convert(T t);
        List<DTO> getListDTO();
    }
}
