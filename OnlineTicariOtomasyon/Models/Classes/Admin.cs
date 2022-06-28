﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Password { get; set; }
        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Authorization { get; set; }//yetki

    }
}