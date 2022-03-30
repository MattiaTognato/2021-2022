using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace projectWorkBiblioteca
{
    public class User
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Email{ get; set; }
        public string Role{ get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Password{ get; set; }
        [JsonProperty("birth_date")]
        public string BirthDate { get; set; }
        public int NPrestiti { get; set; }
        [Browsable(false)]
        public List<Libro> HistoryLibri { get; set; }

        public User()
        {
            HistoryLibri = new List<Libro>();
        }
    }
}
