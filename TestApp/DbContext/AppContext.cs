using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestApp.Models;

namespace TestApp {
	public class AppContext : DbContext {

		public DbSet<TodoItem> Todos { get; set; }

		public AppContext() : base("DefaultCOnnection") { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<TodoItem>()
						.ToTable("Todo");
			modelBuilder.Entity<TodoItem>()
						.HasKey(t => t.Id);
			modelBuilder.Entity<TodoItem>()
						.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
		}
	}
}