using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("film",Schema ="OnlineRezNaBiletZaKino")]
    
    public class Film
    {
        [Key]
        public int id_film { get; set; }

        public string ime_film { get; set; }
        public string reziser { get; set; }
        public TimeSpan? vremetraenje { get; set; }
        public string zanr { get; set; }
        public string tehnologija { get; set; }
        public string film_url { get; set; }
        public string vozrasna_kategorija { get; set; }

    }
}