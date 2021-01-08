using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("bileti_film_godina", Schema = "OnlineRezNaBiletZaKino")]

    public class FilmNaGodinata
    {
        [Key]
        public string Ime { get; set; }
        public double Godina { get; set; }
        public int Bileti { get; set; }
    }
}