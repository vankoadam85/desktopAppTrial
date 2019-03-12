using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partnertar.Data_Access.Interfaces
{
    public interface IReadData<T> where T : class
    {
        Task<T> GetByIDAsync(long ID);

        Task<IEnumerable<T>> GetAllAsync();
    }
}
