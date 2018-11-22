using MobikeApp.Model;
using MobikeApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobikeApp.Services
{
    public class ItemServiceMenu
    {
        private static ObservableCollection<MasterPageItem> MenuLista { get; set; }
        public static ObservableCollection<MasterPageItem> GetMenuLista()
        {
            MenuLista = new ObservableCollection<MasterPageItem>();
            MenuLista.Add(new MasterPageItem { Title = "Home", TargetType = typeof(HomePage) });
            MenuLista.Add(new MasterPageItem { Title = "Produtos", TargetType = typeof(MainPage) });
            MenuLista.Add(new MasterPageItem { Title = "Carrinho", });
            MenuLista.Add(new MasterPageItem { Title = "Meus Pedidos", });

            return MenuLista;
        }
    }
}
