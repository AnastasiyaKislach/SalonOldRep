using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Contracts;
using Salon.Services.Models;

namespace Salon.Services
{
	public class TestimonialService : GenericService<Testimonial, TestimonialEntity>, ITestimonialService
	{
		public TestimonialService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}

		public async Task<IList<Testimonial>> GetAllNotDeletedApproved()
		{
			var entities = await GetWithQueryFilter()
				.Where(m => m.IsDeleted != false)
				.Where(m => m.IsApproved == true)
				.AsQueryable().ToListAsync();
			return Mapper.Map<List<Testimonial>>(entities);
		}

		public async Task<bool> MarkDeleted(int id)
		{
			var testimonialEntity = await UnitOfWork.Repository.GetById<TestimonialEntity>(id);

			testimonialEntity.IsDeleted = !testimonialEntity.IsDeleted;

			await UnitOfWork.Repository.Update(testimonialEntity);
			var result = await UnitOfWork.SaveChangesAsync() > 0;

			return result;
		}
	}
}
