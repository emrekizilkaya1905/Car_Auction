using Auction_Business.Dtos;
using AutoMapper;
using DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Business.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateVehicleDto, Vehicle>().ReverseMap();
			CreateMap<UpdateVehicleDto, Vehicle>().ReverseMap();
		}
	}
}
