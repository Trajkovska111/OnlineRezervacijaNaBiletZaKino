using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("korisnik", Schema = "OnlineRezNaBiletZaKino")]

    public class Korisnik
    {
        [Key]
        public string e_mail { get; set; }
        public string korisnicko_ime { get; set; }
        public string password { get; set; }
    }
}