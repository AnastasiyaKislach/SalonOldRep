using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Threading.Tasks;
using Salon.Data.Repository;

namespace Salon.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly DbContext _context;

		public UnitOfWork(IRepository repository, DbContext context)
		{
			_context = context;
			Repository = repository;
		}

		public async Task<IDbContextTransaction> CreateTransaction()
		{
			return await _context.Database.BeginTransactionAsync();
		}

		public void ChangeTrackingBehaviour(QueryTrackingBehavior trackingBehavior)
		{
			_context.ChangeTracker.QueryTrackingBehavior = trackingBehavior;
		}

		public IRepository Repository { get; private set; }


		public int SaveChanges(bool acceptAllChangesOnSuccess)
		{
			return _context.SaveChanges(acceptAllChangesOnSuccess);
		}

		public int SaveChanges()
		{
			return _context.SaveChanges();
		}

		public async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
			return await _context.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return await _context.SaveChangesAsync(cancellationToken);
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
