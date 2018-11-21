using MobikeApp.Model;
using Xamarin.Forms;

namespace MobikeApp.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
