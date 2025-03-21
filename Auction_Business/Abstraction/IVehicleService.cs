﻿using Auction_Business.Dtos;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Business.Abstraction
{
    public interface IVehicleService
    {
		Task<ApiResponse> CreateVehicle(CreateVehicleDto model);
		Task<ApiResponse> GetVehicles();
		Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDto model);
		Task<ApiResponse> DeleteVehicle(int vehicleId);
		Task<ApiResponse> GetVehicleById(int vehicleId);
		Task<ApiResponse> ChangeVehicleStatus(int vehicleId);
	}
}
