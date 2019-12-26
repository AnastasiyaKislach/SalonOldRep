using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Salon.Data.Configurations;
using Salon.Data.Entities;

namespace Salon.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
		}

		public DbSet<BrandEntity> Brands { get; set; }
		public DbSet<CollectionEntity> Collections { get; set; }
		public DbSet<DressEntity> Dresses { get; set; }
		public DbSet<AppointmentEntity> Appointments { get; set; }
		public DbSet<DressAppointmentEntity> DressAppointments { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<AccessoryEntity> Accessories { get; set; }
		public DbSet<PhotoEntity> Photos { get; set; }
		public DbSet<SettingsEntity> Settings { get; set; }
		public DbSet<NewsEntity> News { get; set; }
		public DbSet<TestimonialEntity> Testimonials { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder
				.ApplyConfiguration(new BrandConfiguration());
			builder
				.ApplyConfiguration(new CollectionConfiguration());
			builder
				.ApplyConfiguration(new CategoryConfiguration());
			builder
				.ApplyConfiguration(new DressAppointmentConfiguration());
		}

		public override int SaveChanges(bool acceptAllChangesOnSuccess)
		{
			ValidateEntities();

			return base.SaveChanges(acceptAllChangesOnSuccess);
		}

		public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
		{
			ValidateEntities();

			return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}

		private void ValidateEntities()
		{
			var entities = from e in ChangeTracker.Entries()
						   where e.State == EntityState.Added
								 || e.State == EntityState.Modified
						   select e.Entity;
			foreach (var entity in entities)
			{
				var validationContext = new ValidationContext(entity);
				Validator.ValidateObject(
					entity,
					validationContext,
					validateAllProperties: false);
			}
		}
	}
}
