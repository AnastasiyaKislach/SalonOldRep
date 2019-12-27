using AutoMapper;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Models;

namespace Salon.Services
{
	public class NewsService : GenericService<News, NewsEntity>
	{
		public NewsService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}
	}
}
