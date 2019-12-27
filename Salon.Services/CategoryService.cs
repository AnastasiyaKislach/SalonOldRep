using AutoMapper;
using System.Threading.Tasks;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Contracts;
using Salon.Services.Models;

namespace Salon.Services
{
	public class CategoryService : GenericService<Category, CategoryEntity>, ICategoryService
	{
		public CategoryService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}

		public async Task<bool> MarkDeleted(int id)
		{
			var categoryEntity = await UnitOfWork.Repository.GetById<CategoryEntity>(id);

			categoryEntity.IsDeleted = !categoryEntity.IsDeleted;

			await UnitOfWork.Repository.Update(categoryEntity);
			var result = await UnitOfWork.SaveChangesAsync() > 0;

			return result;
		}
	}
}
