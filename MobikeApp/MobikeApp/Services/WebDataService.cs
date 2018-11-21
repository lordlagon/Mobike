using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MobikeApp.Model;
using MobikeApp.Services;
using Xamarin.Forms;

[assembly:Dependency(typeof(WebDataService))]
namespace MobikeApp.Services
{
    public class WebDataService : IDataService
    {
        HttpClient httpClient;
        HttpClient Client => httpClient ?? (httpClient = new HttpClient());
        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            var json = await Client.GetStringAsync("http://localhost:8094/produto/listar");
            var all = Produto.FromJson(json);
            return all;
        }

    }
}
