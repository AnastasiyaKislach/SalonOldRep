using AutoMapper;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Models;

namespace Salon.Services
{
	public class AccessoryService : GenericService<Accessory, AccessoryEntity>
	{
		public AccessoryService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}
	}
}
