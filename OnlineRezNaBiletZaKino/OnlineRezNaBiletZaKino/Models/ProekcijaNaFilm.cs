using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("proekcija_na_film", Schema = "OnlineRezNaBiletZaKino")]

    public class ProekcijaNaFilm
    {
        [Key]
        [Column(Order = 0)]
        public int id_proekcija { get; set; }
        [Key]
        [Column(Order = 1)]
        public int id_film { get; set; }
        public string ime_film { get; set; }
        public string tehnologija { get; set; }
        public DateTime datum { get; set; }
        public TimeSpan vreme_pocetok { get; set; }
        public int broj_sala { get; set; }


    }
}