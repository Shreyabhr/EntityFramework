using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository
{
    public interface IBankGenericRepository<T> where T : class
    {
        IQueryable<T> GetModel();

        T GetById(Guid id);
       
        void Insert(T model);

        void Update(T model);

    }
}
