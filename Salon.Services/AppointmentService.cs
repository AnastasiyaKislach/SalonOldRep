using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Contracts;
using Salon.Services.Models;

namespace Salon.Services
{
	public class AppointmentService : GenericService<Appointment, AppointmentEntity>, IAppointmentService
	{
		public AppointmentService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}

		public Task<Appointment> CreateAppointmentWithDresses(Appointment appointment, IList<int> dresses)
		{
			throw new NotImplementedException();
		}
	}
}
