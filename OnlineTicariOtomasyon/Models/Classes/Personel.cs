using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string PersonelName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string PersonelSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string PersonelImages { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }

        public Department Department { get; set; }



    }
}