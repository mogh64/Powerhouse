using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerhouse.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int Id);
        IEnumerable<T> Get();
        void Add(T item);
        void Delete(int Id);
        void Update(T item);
    }
}
