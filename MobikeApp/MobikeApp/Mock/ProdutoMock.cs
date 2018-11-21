using MobikeApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobikeApp.Mock
{
     public class ProdutoMock
    {
        public List<Produto> ListProdutos;

        public ProdutoMock()
        {
            GetListProdutos();
        }

        private void GetListProdutos()
        {
            ListProdutos = new List<Produto>()
            {
                new Produto(){Nome = "Caloi",Cor="verde", Classe="speed", PrecoVenda= 2000 },
                new Produto(){Nome = "Sundown",Cor="verde", Classe="speed", PrecoVenda= 2000 },
                new Produto(){Nome = "Ceci",Cor="verde", Classe="speed", PrecoVenda= 2000}


            };
        }
    }
}