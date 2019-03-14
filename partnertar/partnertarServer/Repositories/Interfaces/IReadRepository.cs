using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace partnertarServer.Repositories.Interfaces
{
    public interface IReadRepository<T> where T : class
    {
        Task<T> GetByIDAsync(long ID);

        Task<IEnumerable<T>> GetAllAsync();
    }
}