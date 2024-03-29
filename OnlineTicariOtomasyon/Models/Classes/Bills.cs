﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Bills
    {
        //Faturalar Sınıfı. Türkçe Yaptım İngilizce Seviyem Yetmedi
        [Key]
        public int FaturaId { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string VergiDairesi { get; set; }
        public DateTime Saat { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string TeslimEden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string TeslimAlan { get; set; }
        public ICollection<FaturaKalem> faturaKalems { get; set; }
    }
}