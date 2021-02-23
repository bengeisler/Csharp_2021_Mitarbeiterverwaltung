using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Csharp_2021_Mitarbeiterverwaltung
{
	public partial class MitarbeiterverwaltungContext : DbContext
	{
		public MitarbeiterverwaltungContext()
				: base("name=MitarbeiterverwaltungContext")
		{
		}

		public virtual DbSet<Abteilung> Abteilungs { get; set; }
		public virtual DbSet<Mitarbeiter> Mitarbeiters { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Abteilung>()
					.Property(e => e.Bezeichnung)
					.IsUnicode(false);

			modelBuilder.Entity<Abteilung>()
					.HasMany(e => e.Mitarbeiters)
					.WithRequired(e => e.Abteilung)
					.WillCascadeOnDelete(false);

			modelBuilder.Entity<Mitarbeiter>()
					.Property(e => e.Name)
					.IsUnicode(false);

			modelBuilder.Entity<Mitarbeiter>()
					.Property(e => e.Vorname)
					.IsUnicode(false);

			modelBuilder.Entity<Mitarbeiter>()
					.Property(e => e.Stellenbezeichnung)
					.IsUnicode(false);

			modelBuilder.Entity<Mitarbeiter>()
					.Property(e => e.Adresse)
					.IsUnicode(false);

			modelBuilder.Entity<Mitarbeiter>()
					.Property(e => e.PLZ)
					.IsUnicode(false);

			modelBuilder.Entity<Mitarbeiter>()
					.Property(e => e.Ort)
					.IsUnicode(false);

			modelBuilder.Entity<Mitarbeiter>()
					.Property(e => e.Telefon)
					.IsUnicode(false);
		}
	}
}
