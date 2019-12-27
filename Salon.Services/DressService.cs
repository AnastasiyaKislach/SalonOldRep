using AutoMapper;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Models;

namespace Salon.Services
{
	public class DressService : GenericService<Dress, DressEntity>
	{
		public DressService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}
	}
}
