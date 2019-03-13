using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertarServer.Services.Interfaces
{
    public interface IReadService<T> where T : class
    {
        Task<T> GetByIDAsync(long ID);

        Task<IEnumerable<T>> GetAllAsync();
    }
}
