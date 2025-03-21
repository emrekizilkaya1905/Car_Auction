using Auction_Business.Abstraction;
using Auction_Business.Dtos;
using AutoMapper;
using Core.Model;
using DataAccess.Context;
using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Business.Concrete
{
	public class PaymentHistoryService : IPaymentHistoryService
	{
		private ApiResponse _response;
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public PaymentHistoryService(ApiResponse response, ApplicationDbContext context, IMapper mapper)
		{
			_response = response;
			_context = context;
			_mapper = mapper;
		}

		public async Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId)
		{
			var result = await _context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).
			FirstOrDefaultAsync();
			if(result !=null)
			{
				_response.isSuccess = true;
				_response.Result = result;
				return _response;
			}
			_response.isSuccess = false;
			return _response;
		} 

		public async Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDto model)
		{
			if(model == null)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("Model is not include the fields");
				return _response;
			}
			var objDto=_mapper.Map<PaymentHistory>(model);
			objDto.PayDate = DateTime.Now;
			objDto.IsActive = true;
			if (await _context.SaveChangesAsync() > 0) 
			{
				_response.isSuccess = true;
				_response.Result = model;
				return _response;
			}
			_response.isSuccess = false;
			_response.ErrorMessages.Add("Oops something went wrong");
		
			return _response;
		}
	}
}
