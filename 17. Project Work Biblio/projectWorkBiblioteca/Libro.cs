using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWorkBiblioteca
{
    public class Libro
    {
        [JsonProperty("isbn")]
        public string ISBN { get; set; }

        [JsonProperty("title")]
        public string Titolo { get; set; }
        
        [JsonProperty("subtitle")]
        public string Sottotitolo { get; set; }
        
        [JsonProperty("description")]
        public string Descrizione { get; set; }
        
        [JsonProperty("authors")]
        public string Autori { get; set; }
        
        [JsonProperty("published_year")]
        public string Anno { get; set; }
        
        [JsonProperty("categories")]
        public string Categorie { get; set; }
        
        [JsonProperty("thumbnail")]
        public string Immagine { get; set; }
        
        [JsonProperty("qta")]
        public int Quantita { get; set; }
        
        [JsonProperty("average_rating")]
        public float Media { get; set; }
        
        [JsonProperty("ratings_count")]
        public int NVoti{ get; set; }

        [JsonProperty("num_pages")]
        public int NPagine { get; set; }
    }
}
