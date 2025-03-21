﻿using Auction_Business.Dtos;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Business.Abstraction
{
   public interface IUserService
    {
		Task<ApiResponse> Register(RegisterRequestDto model);

		Task<ApiResponse> Login(LoginRequestDto model);
	}
}
