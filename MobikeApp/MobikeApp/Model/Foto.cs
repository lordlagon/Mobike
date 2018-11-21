using Newtonsoft.Json;
using System;

namespace MobikeApp.Model
{
    public class Foto
    {
        [JsonProperty("fotoId")]
        public long FotoId { get; set; }

        [JsonProperty("imagemPequena")]
        public string ImagemPequena;

        [JsonProperty("nomeImagemPequena")]
        public string NomeImagemPequena;

        [JsonProperty("imagemGrande")]
        public Uri ImagemGrande;

        [JsonProperty("nomeImagemGrande")]
        public string NomeImagemGrande;

        [JsonProperty("principal")]
        public bool Principal;

        [JsonProperty("dataModificacao")]
        public object DataModificacao;
    }
}