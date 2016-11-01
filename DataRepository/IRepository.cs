using System.Collections.Generic;

namespace DataRepository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int Id);
    }
}
