using MobikeApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                new Produto(){Nome = "Caloi",Cor="verde", Classe="speed", PrecoVenda= 2000, Imagem=new Uri("https://static.netshoes.com.br/produtos/bicicleta-gts-feel-aro-26-freio-a-disco-21-marchas/06/W88-0002-006/W88-0002-006_zoom1.jpg")},
                new Produto(){Nome = "Sundown",Cor="verde", Classe="speed", PrecoVenda= 2000 ,Imagem=new Uri("https://static.netshoes.com.br/produtos/bicicleta-gts-feel-aro-26-freio-a-disco-21-marchas/06/W88-0002-006/W88-0002-006_zoom1.jpg")},
                new Produto(){Nome = "Ceci",Cor="verde", Classe="speed", PrecoVenda= 2000,Imagem=new Uri("https://static.netshoes.com.br/produtos/bicicleta-gts-feel-aro-26-freio-a-disco-21-marchas/06/W88-0002-006/W88-0002-006_zoom1.jpg")},
                new Produto()
                {
                    ProdutoId = 2,
                    Nome = "teste2",
                    NumeroProduto =  "3",
                    NivelEstoque =  20,
                    PontoReordenar =  3,
                    CustoPadrao =  800,
                    PrecoVenda =  800,
                    TamanhoProduto =  null,
                    UnidadeMedidaTamanho =  null,
                    UnidadeMedidaPeso =  null,
                    PesoProduto =  30,
                    DiasParaFabricarProduto =  20,
                    LinhaDoProduto =  null,
                    Classe =  "MontainBike",
                    Estilo =  null,
                    DataDisponivelVenda =  null,
                    DataNaoDisponivelVenda =  null,
                    DataProdutoDescontinuado =  null,
                    DataModificacao =  null,
                    Fotos =  null,
                    Revisaos =  null,
                    ProdutoSubCategorias =  null,
                    Documentos =  null,
                    Modelos =  null,
                    UnidadeMedida =  null,
                    Cor =  "Preta",
                    Imagem=new Uri("https://static.netshoes.com.br/produtos/bicicleta-gts-feel-aro-26-freio-a-disco-21-marchas/06/W88-0002-006/W88-0002-006_zoom1.jpg")
                }

            };



        }

    }
}