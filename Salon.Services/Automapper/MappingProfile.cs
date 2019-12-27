using AutoMapper;
using Salon.Data.Entities;
using Salon.Services.Models;
using System.Linq;

namespace Salon.Services.Automapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<AccessoryEntity, Accessory>();
			CreateMap<Accessory, AccessoryEntity>();

			CreateMap<AppointmentEntity, Appointment>()
				.ForMember(a => a.Dresses, cfg => cfg.MapFrom(ae => ae.DressAppointments.Select(m => m.DressId)));
			CreateMap<Appointment, AppointmentEntity>();

			CreateMap<BrandEntity, Brand>()
				.ForMember(a => a.Collections, cfg => cfg.MapFrom(ae => ae.Collections.Select(m => m.Id))); 
			CreateMap<Brand, BrandEntity>();

			CreateMap<CategoryEntity, Category>()
				.ForMember(a => a.Accessories, cfg => cfg.MapFrom(ae => ae.Accessories.Select(m => m.Id)));
			CreateMap<Category, CategoryEntity>();

			CreateMap<CollectionEntity, Collection>()
				.ForMember(a => a.Dresses, cfg => cfg.MapFrom(ae => ae.Dresses.Select(m => m.Id)));
			CreateMap<Collection, CollectionEntity>();

			CreateMap<Dress, DressEntity>();
			CreateMap<DressEntity, Dress>();

			CreateMap<News, NewsEntity>();
			CreateMap<NewsEntity, News>();

			CreateMap<Photo, PhotoEntity>();
			CreateMap<PhotoEntity, Photo>();

			CreateMap<Settings, SettingsEntity>();
			CreateMap<SettingsEntity, Settings>();

			CreateMap<Testimonial, TestimonialEntity>();
			CreateMap<TestimonialEntity, Testimonial>();
		}
	}
}
