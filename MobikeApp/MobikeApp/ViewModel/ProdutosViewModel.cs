using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

using System.Linq;
using MobikeApp.Model;
using System.Diagnostics;
using System.Collections.ObjectModel;
using MobikeApp.Mock;

namespace MobikeApp.ViewModel
{
    public class ProdutosViewModel : BaseViewModel
    {
        public ObservableCollection<Produto> Produtos { get; }
        public Command GetProdutosCommand { get; }
        public Command GetClosestCommand { get; }
        public ProdutosViewModel()
        {
            Title = "Buscar Produtos";
            Produtos = new ObservableCollection<Produto>();
            GetProdutosCommand = new Command(async () => await GetProdutosAsync());
            
        }

    
        async Task GetProdutosAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                ProdutoMock produtoMock = new ProdutoMock();
                //var produtos = await DataService.GetProdutosAsync();
                var produtos = produtoMock.ListProdutos;

                Produtos.Clear();
                foreach (var produto in produtos)
                    Produtos.Add(produto);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Incapaz de trazer os Produtos: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Erro!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

       


    }
}
