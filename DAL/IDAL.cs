using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.DAL
{
    interface IDAL<T>
    {
        List<T> GetList();
        bool Insert(T o);
        bool Delete(T o);
        bool Update(T o);

        T FindByID(string id);
    }
}
