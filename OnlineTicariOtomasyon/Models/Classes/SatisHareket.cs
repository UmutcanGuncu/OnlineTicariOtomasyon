using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class SatisHareket
    {
        [Key]
        public int SaleId { get; set; }
        //Ürün
        //Cari
        //Personel
        public DateTime Date { get; set; }
        public int Piece { get; set; }
        public decimal Total { get; set; } //Fiyat
        public decimal TotalPrice { get; set; } //Toplam Tutar
        public ICollection<Product> Uruns { get; set; }
        public ICollection<Cari> Carilers { get; set; }
        public ICollection<Personel> Personels { get; set; }
        


    }
}