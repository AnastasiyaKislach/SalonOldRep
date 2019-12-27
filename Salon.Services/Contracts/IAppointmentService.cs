using System.Collections.Generic;
using System.Threading.Tasks;
using Salon.Services.Models;

namespace Salon.Services.Contracts
{
	public interface IAppointmentService : IGenericService<Appointment>
	{
		public Task<Appointment> CreateAppointmentWithDresses(Appointment appointment, IList<int> dresses);
	}
}
