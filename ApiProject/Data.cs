using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiProject.Models;
namespace ApiProject
{
    public class Data:DbContext
    {
        DbSet<Ogrenci> Ogrenciler { get; set; }
        DbSet<OgretimUyesi> OgretimUyeleri { get; set; }
        DbSet<Ders> Dersler { get; set; }
        public Data(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>()
                .HasMany(d => d.dOgrenciler)
                .WithMany(o => o.aldigiDersler);
            modelBuilder.Entity<Ders>()
                .HasOne(d => d.dOgretimUyesi)
                .WithMany(o => o.verdigiDersler);
        }
    }
}
