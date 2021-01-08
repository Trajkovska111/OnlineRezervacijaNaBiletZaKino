using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("info_po_korisnik", Schema = "OnlineRezNaBiletZaKino")]

    public class NajredovenKorisnik
    {
        [Key]
        public string Korisnicko_ime { get; set; }
        public int Suma_od_bileti { get; set; }
        public int Broj_bileti { get; set; }
    }
}