using System.Threading.Tasks;
using Salon.Services.Models;

namespace Salon.Services.Contracts
{
	public interface IBrandService : IGenericService<Brand>
	{
		Task<bool> MarkDeleted(int id);
	}
}
