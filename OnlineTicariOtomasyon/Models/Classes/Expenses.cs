using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Expenses
    {
        //Giderler
        [Key]
        public int ExpensesId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string ExpensesExplanation { get; set; } //Gider Açıklama
    
        public DateTime Date { get; set; }
        
        public decimal Total { get; set; }//Tutar
    
    }
}