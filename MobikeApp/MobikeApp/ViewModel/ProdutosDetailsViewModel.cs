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
        public Command OpenMapCommand { get; }

        public ProdutosDetailsViewModel()
        {

          //  OpenMapCommand = new Command(async () => await OpenMapAsync()); 
        }

        public ProdutosDetailsViewModel(Produto monkey) 
            : this()
        {
            Produto = monkey;
            Title = $"{Produto.Nome} Details";
        }
        Produto monkey;
        public Produto Produto
        {
            get => monkey;
            set
            {
                if (monkey == value)
                    return;

                monkey = value;
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
