using AutoMapper;
using System.Threading.Tasks;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Contracts;
using Salon.Services.Models;

namespace Salon.Services
{
	public class BrandService : GenericService<Brand, BrandEntity>, IBrandService
	{
		public BrandService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}

		public async Task<bool> MarkDeleted(int id)
		{
			var brandEntity = await UnitOfWork.Repository.GetById<BrandEntity>(id);

			brandEntity.IsDeleted = !brandEntity.IsDeleted;

			await UnitOfWork.Repository.Update(brandEntity);
			var result = await UnitOfWork.SaveChangesAsync() > 0;

			return result;
		}
	}
}
