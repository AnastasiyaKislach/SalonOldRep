﻿using AutoMapper;
using Salon.Data;
using Salon.Data.Entities;
using Salon.Services.Models;

namespace Salon.Services
{
	public class PhotoService : GenericService<Photo, PhotoEntity>
	{
		public PhotoService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{
		}
	}
}
