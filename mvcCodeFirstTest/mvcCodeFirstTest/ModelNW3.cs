namespace mvcCodeFirstTest
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class ModelNW3 : DbContext
	{
		public ModelNW3()
				: base("name=ModelNW3")
		{
		}

		public virtual DbSet<tb_mig1> tb_Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<tb_mig1>()
					.Property(e => e.UserName)
					.IsUnicode(false);

			modelBuilder.Entity<tb_mig1>()
					.Property(e => e.Password)
					.IsUnicode(false);

			modelBuilder.Entity<tb_mig1>()
					.Property(e => e.Email)
					.IsUnicode(false);

			modelBuilder.Entity<tb_mig1>()
				.Property(e => e.BirthDate);

			//modelBuilder.Entity<tb_mig1>()
			//	.Property(e => e.Adress)
			//	.IsUnicode(false);


		}
	}
}
