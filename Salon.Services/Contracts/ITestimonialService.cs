using System.Collections.Generic;
using System.Threading.Tasks;
using Salon.Services.Models;

namespace Salon.Services.Contracts
{
	public interface ITestimonialService : IGenericService<Testimonial>
	{
		Task<IList<Testimonial>> GetAllNotDeletedApproved();

		Task<bool> MarkDeleted(int id);
	}
}
