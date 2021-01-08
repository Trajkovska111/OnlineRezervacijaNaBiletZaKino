using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("proekcija", Schema = "OnlineRezNaBiletZaKino")]
    public class Proekcija
    {
        [Key]
        [Column(Order = 0)]
        public int id_proekcija { get; set; }
        [Key]
        [Column(Order = 1)]
        public int id_film { get; set; }
        public DateTime vreme_pocetok { get; set; }
        public DateTime vreme_kraj { get; set; }
    }
}