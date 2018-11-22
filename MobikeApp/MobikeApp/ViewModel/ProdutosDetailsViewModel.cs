using MobikeApp.Model;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobikeApp.ViewModel
{
    public class ProdutosDetailsViewModel : BaseViewModel
    {
        public Command AddCarrinhoCommand { get; }
       

        public ProdutosDetailsViewModel()
        {

            //  OpenMapCommand = new Command(async () => await OpenMapAsync()); 
        }

        public ProdutosDetailsViewModel(Produto produto) : this()
        {
            Produto = produto;
            Title = $"Detalhes {Produto.Nome} ";
            Detalhes = $"Modelo: {Produto.Classe} /n Cor: {Produto.Cor} ";
        }
        private Produto _produto;
        public Produto Produto
        {
            get => _produto;
            set
            {
                if (_produto == value)
                    return;

                _produto = value;
                OnPropertyChanged();
            }
        }
        private string _detalhes;
        public string Detalhes
        {
            get => _detalhes;
            set
            {
                if (_detalhes == value)
                    return;

                _detalhes = value;
                OnPropertyChanged();
            }
        }

        //async Task OpenMapAsync()
        //{
        //    try
        //    {
        //        await Maps.OpenAsync(Monkey.Latitude, Monkey.Longitude);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine($"Unable to launch maps: {ex.Message}");
        //        await Application.Current.MainPage.DisplayAlert("Error, no Maps app!", ex.Message, "OK");
        //    }
        //}
    }
}
