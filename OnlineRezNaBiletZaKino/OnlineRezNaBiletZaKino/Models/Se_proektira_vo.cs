using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("se_proektira_vo", Schema = "OnlineRezNaBiletZaKino")]

    public class Se_proektira_vo
    {
        [Key]
        [Column(Order = 0)]
        public int id_proekcija { get; set; }
        [Key]
        [Column(Order = 1)]
        public int id_film { get; set; }
        [Key]
        [Column(Order = 2)]
        public int broj_sala { get; set; }
        
    }
}