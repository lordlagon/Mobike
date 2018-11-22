using Newtonsoft.Json;
using System;

namespace MobikeApp.Model
{
    public class Foto
    {
        [JsonProperty("fotoId")]
        public long FotoId { get; set; }

        [JsonProperty("imagemPequena")]
        public Uri ImagemPequena { get; set; }

        [JsonProperty("nomeImagemPequena")]
        public string NomeImagemPequena { get; set; }

        [JsonProperty("imagemGrande")]
        public string ImagemGrande { get; set; }

        [JsonProperty("nomeImagemGrande")]
        public string NomeImagemGrande { get; set; }

        [JsonProperty("principal")]
        public bool Principal { get; set; }

        [JsonProperty("dataModificacao")]
        public object DataModificacao { get; set; }

    }
}