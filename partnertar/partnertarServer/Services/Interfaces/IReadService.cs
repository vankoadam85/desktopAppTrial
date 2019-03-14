using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertarServer.Services.Interfaces
{
    public interface IReadService<T, U> where T : class where U : class
    {
        Task<T> GetByIDAsync(long ID);

        Task<U> GetAllAsync();
    }
}
