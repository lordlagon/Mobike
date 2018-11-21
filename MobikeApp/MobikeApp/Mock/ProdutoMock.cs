using MobikeApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobikeApp.Mock
{
     public class ProdutoMock
    {
        public List<Produto> ListProdutos;
        public Foto[] fotos;
        public ProdutoMock()
        {
            GetListProdutos();
        }

        private void GetListProdutos()
        {
            ListProdutos = new List<Produto>()
            {
                new Produto(){Nome = "Caloi",Cor="verde", Classe="speed", PrecoVenda= 2000, Fotos = fotos },
                new Produto(){Nome = "Sundown",Cor="verde", Classe="speed", PrecoVenda= 2000 },
                new Produto(){Nome = "Ceci",Cor="verde", Classe="speed", PrecoVenda= 2000}


            };

            fotos = new Foto[]            {
                new Foto (){ImagemGrande = "https://static.netshoes.com.br/produtos/bicicleta-gts-feel-aro-26-freio-a-disco-21-marchas/06/W88-0002-006/W88-0002-006_zoom1.jpg" },
            };
        }
    }
}