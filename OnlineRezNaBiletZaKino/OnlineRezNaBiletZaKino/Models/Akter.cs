using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("akteri", Schema = "OnlineRezNaBiletZaKino")]
    public class Akter
    {
        [Key]
        [Column(Order = 0)]
        public int id_film { get; set; }
        [Key]
        [Column(Order = 1)]
        public string akteri { get; set; }

        

    }
}