using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineRezNaBiletZaKino.Models
{
    [Table("prosecen_promet_po_mesec", Schema = "OnlineRezNaBiletZaKino")]

    public class ProsecenPrometPoMesec
    {
        [Key]
        [Column(Order = 0)]
        public double Mesec { get; set; }
        [Key]
        [Column(Order = 1)]
        public double Godina { get; set; }
        public double Prosecen_promet { get; set; }
    }
}