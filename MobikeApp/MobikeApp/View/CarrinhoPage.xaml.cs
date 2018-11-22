using MobikeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobikeApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarrinhoPage : ContentPage
	{
		public CarrinhoPage ()
		{
			InitializeComponent ();
		}

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var produto = e.SelectedItem as Produto;
            if (produto == null)
                return;

            await Navigation.PushAsync(new DetailsPage(produto));

            ((ListView)sender).SelectedItem = null;
        }
    }
}