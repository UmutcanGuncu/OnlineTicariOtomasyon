using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<Cari> caris { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<FaturaKalem> faturaKalems { get; set; }
        public DbSet<Bills> bills { get; set; }
        public DbSet<Expenses> expenses { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<SatisHareket> satisHarekets { get; set; }
        public DbSet<Product> products{ get; set; }


    }
}