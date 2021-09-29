using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public interface IgenRepo<T> where T:class,IBM
    {
        Task<IEnumerable<T>> GetAll();
         Task<T> GetById(int id);
        Task DeleteByid(int id);
        Task AddObj(T obj);
        Task<IEnumerable<T>> GetPage(int size, int index);
    }
}
