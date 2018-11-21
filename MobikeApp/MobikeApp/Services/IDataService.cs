using MobikeApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobikeApp.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
    }
}
