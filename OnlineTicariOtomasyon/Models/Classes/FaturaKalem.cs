﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string FaturaKalemAciklama { get; set; }

        public int FaturaKalemMiktar{ get; set; }
        public decimal FaturaKalemBirimFiyat { get; set; }

        public decimal FaturaKalemTutar { get; set; }

        public  Bills Bills { get; set; }
    }
}