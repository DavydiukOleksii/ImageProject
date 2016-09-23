using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int Id);
    }
}
