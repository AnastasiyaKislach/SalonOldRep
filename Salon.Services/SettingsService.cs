using AutoMapper;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Models;

namespace Salon.Services
{
	public class SettingsService : GenericService<Settings, SettingsEntity>
	{
		public SettingsService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}
	}
}
