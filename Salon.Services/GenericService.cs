using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Contracts;

namespace Salon.Services
{
	public class GenericService<TModel, TEntity> : IGenericService<TModel> where TEntity : class, IEntityBase
	{
		protected readonly IMapper Mapper;
		protected readonly IUnitOfWork UnitOfWork;

		public GenericService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected virtual IQueryable<TEntity> GetWithQueryFilter()
		{
			return UnitOfWork.Repository.GetAll<TEntity>().AsQueryable();
		}

		public virtual async Task<List<TModel>> GetAll()
		{
			var entities = await GetWithQueryFilter().ToListAsync();
			var result = entities.Select(e => Mapper.Map<TEntity, TModel>(e)).ToList();
			return result;
		}

		public virtual async Task<TModel> GetById(int id)
		{
			var model = Mapper.Map<TEntity, TModel>(await GetWithQueryFilter().SingleAsync(e => e.Id == id));
			return model;
		}

		public virtual async Task<int> Create(TModel model)
		{
			TEntity entity = Mapper.Map<TModel, TEntity>(model);
			await UnitOfWork.Repository.Create(entity);
			await UnitOfWork.SaveChangesAsync();
			return entity.Id;
		}

		public virtual async Task Update(TModel model)
		{
			TEntity entity = Mapper.Map<TModel, TEntity>(model);

			await UnitOfWork.Repository.Update(entity);
			await UnitOfWork.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			await UnitOfWork.Repository.Delete<TEntity>(id);
			await UnitOfWork.SaveChangesAsync();
		}
	}
}
