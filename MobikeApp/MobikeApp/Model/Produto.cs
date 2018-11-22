using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MobikeApp.Model
{
    public partial class Produto
    {
        [JsonProperty("produtoId")]
        public int ProdutoId { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("numeroProduto")]
        public string NumeroProduto { get; set; }
        [JsonProperty("nivelEstoque")]
        public int NivelEstoque { get; set; }
        [JsonProperty("pontoReordenar")]
        public int PontoReordenar { get; set; }
        [JsonProperty("custoPadrao")]
        public int CustoPadrao { get; set; }
        [JsonProperty("precoVenda")]
        public int PrecoVenda { get; set; }
        [JsonProperty("tamanhoProduto")]
        public object TamanhoProduto { get; set; }
        [JsonProperty("unidadeMedidaTamanho")]
        public object UnidadeMedidaTamanho { get; set; }
        [JsonProperty("unidadeMedidaPeso")]
        public object UnidadeMedidaPeso { get; set; }
        [JsonProperty("pesoProduto")]
        public int PesoProduto { get; set; }
        [JsonProperty("diasParaFabricarProduto")]
        public int DiasParaFabricarProduto { get; set; }
        [JsonProperty("linhaDoProduto")]
        public object LinhaDoProduto { get; set; }
        [JsonProperty("classe")]
        public object Classe { get; set; }
        [JsonProperty("estilo")]
        public object Estilo { get; set; }
        [JsonProperty("dataDisponivelVenda")]
        public object DataDisponivelVenda { get; set; }
        [JsonProperty("dataNaoDisponivelVenda")]
        public object DataNaoDisponivelVenda { get; set; }
        [JsonProperty("dataProdutoDescontinuado")]
        public object DataProdutoDescontinuado { get; set; }
        [JsonProperty("dataModificacao")]
        public object DataModificacao { get; set; }
        [JsonProperty("fotos")]
        public List<Foto> Fotos { get; set; }
        public Uri Imagem { get; set; }
        [JsonProperty("revisaos")]
        public object[] Revisaos { get; set; }
        [JsonProperty("produtoSubCategorias")]
        public object[] ProdutoSubCategorias { get; set; }
        [JsonProperty("documentos")]
        public object[] Documentos { get; set; }
        [JsonProperty("modelos")]
        public object[] Modelos { get; set; }
        [JsonProperty("unidadeMedida")]
        public object UnidadeMedida { get; set; }
        [JsonProperty("cor")]
        public object Cor { get; set; }

        
    }

    public partial class Produto
    {
        public static Produto[] FromJson(string json) => JsonConvert.DeserializeObject<Produto[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Produto[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

