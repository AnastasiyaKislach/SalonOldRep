using AutoMapper;
using System.Threading.Tasks;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Contracts;
using Salon.Services.Models;

namespace Salon.Services
{
	public class CollectionService : GenericService<Collection, CollectionEntity>, ICollectionService
	{
		public CollectionService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}

		public async Task<bool> MarkDeleted(int id)
		{
			var collectionEntity = await UnitOfWork.Repository.GetById<CollectionEntity>(id);

			collectionEntity.IsDeleted = !collectionEntity.IsDeleted;

			await UnitOfWork.Repository.Update(collectionEntity);
			var result = await UnitOfWork.SaveChangesAsync() > 0;

			return result;
		}
	}
}
