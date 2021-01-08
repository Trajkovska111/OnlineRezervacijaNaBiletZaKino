using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("info_za_bilet", Schema = "OnlineRezNaBiletZaKino")]
    public class InfoBilet
    {
        [Key]
        public int IDbilet { get; set; }
        public string Korisnik { get; set; }
        public int Cena { get; set; }
        public string Ime_film { get; set; }
        public string Tehnologija { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan Vreme_pocnuvanje { get; set; }
        public int Sala { get; set; }
        public int Sediste { get; set; }
        public int Red { get; set; }
    }
}