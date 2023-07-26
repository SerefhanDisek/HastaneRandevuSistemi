using HastaneRandevuSistemi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HastaneRandevuSistemi.Models
{
	public class HastaneRandevuContext : DbContext

	{
		public DbSet<Birim> Birims { get; set; }
		public DbSet<Doktor> Doktors { get; set; }
		public DbSet<Hasta> Hasta { get; set; }
		public DbSet<Hastalik> hastaliks { get; set; }
		public DbSet<Poliklinik> polikliniks { get; set; }
		public DbSet<Randevu> randevus { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
			Database=HastaneRandevuSistemi;Trusted_Connection=True;");
		}
	}
}
