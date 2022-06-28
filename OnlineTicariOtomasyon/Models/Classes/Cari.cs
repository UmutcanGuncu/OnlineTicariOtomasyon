using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Cari
    {
        [Key]
        public int CariId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CariCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }
        public SatisHareket SatisHareket { get; set; }
    }
}