using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading;
using System.Threading.Tasks;
using Salon.Data.Repository;

namespace Salon.Data
{
	public interface IUnitOfWork : IDisposable
	{
		void ChangeTrackingBehaviour(QueryTrackingBehavior trackingBehavior);

		IRepository Repository { get; }

		int SaveChanges(bool acceptAllChangesOnSuccess);

		int SaveChanges();

		Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());

		Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

		Task<IDbContextTransaction> CreateTransaction();
	}
}
