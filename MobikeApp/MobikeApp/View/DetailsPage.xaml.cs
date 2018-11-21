using MobikeApp.Model;
using MobikeApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobikeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }
        public DetailsPage(Produto produto)
        {
            InitializeComponent();
            BindingContext = new ProdutosDetailsViewModel(produto);
            
        }
    }
}