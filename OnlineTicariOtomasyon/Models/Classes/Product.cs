using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string ProductMark { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductBuyPrice { get; set; }
        public decimal ProductSalePrice { get; set; }
        public bool ProductSituation { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string ProductImages { get; set; }

        public Category Category  { get; set; }
        public SatisHareket SatisHareket { get; set; }



    }
}