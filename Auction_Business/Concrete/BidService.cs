using Auction_Business.Abstraction;
using Auction_Business.Dtos;
using AutoMapper;
using Core.MailHelper;
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
	public class BidService : IBidService
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;
		private readonly ApiResponse _response;
		private readonly IMailService _mailService;

		public BidService(ApplicationDbContext context, IMapper mapper, ApiResponse response, IMailService mailService)
		{
			_context = context;
			_mapper = mapper;
			_response = response;
			_mailService = mailService;
		}

		public async Task<ApiResponse> AutomaticallyCreateBid(CreateBidDto model)
		{
			var isPaid = await CheckIsPaidAuction(model.UserId, model.VehicleId);
			if (!isPaid)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("You must pay the auction price before proceeding with this action.");
				return _response;
			}
			var result = await _context.Bids.Where(x => x.VehicleId == model.VehicleId && x.Vehicle.IsActive == true).
				OrderByDescending(x => x.BidAmount).ToListAsync();
			if(result.Count==0)
			{
				_response.isSuccess = false;
				return _response;
			}
			var objDto = _mapper.Map<Bid>(model);
			objDto.BidAmount = result[0].BidAmount + (result[0].BidAmount * 10) / 100;
			objDto.BidDate = DateTime.Now;
			_context.Bids.Add(objDto);
			await _context.SaveChangesAsync();
			_response.isSuccess = true;
			_response.Result = result;
			return _response;
		}

		public Task<ApiResponse> CancelBid(int bidId)
		{
			throw new NotImplementedException();
		}

		public async Task<ApiResponse> CreateBid(CreateBidDto model)
		{
			var returnValue = await CheckIsActive(model.VehicleId);
			var isPaid = await CheckIsPaidAuction(model.UserId, model.VehicleId);

			if (!isPaid)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("You must pay the auction price before proceeding with this action.");
				return _response;
			}
			if (returnValue==null)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("This car is not active");
			}

			if (returnValue!.Price >= model.BidAmount)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("You should surpass the highest bid in the placed bids.");
				return _response;
			}
			if(model != null)
			{
				var topPrice = await _context.Bids.Where(x => x.VehicleId == model.VehicleId).
				OrderByDescending(x => x.BidAmount).ToListAsync();
				if(topPrice.Count!=0)
				{
					if (topPrice[0].BidAmount >= model.BidAmount)
					{
						_response.isSuccess = false;
						_response.ErrorMessages.
						Add("Entry bid amount must not lower than the higher price in the system, higher price is" + topPrice[0].BidAmount);
						return _response;
					}
				}
				Bid bid = _mapper.Map<Bid>(model);
				bid.BidDate = DateTime.Now;
				await _context.Bids.AddAsync(bid);
				if(await _context.SaveChangesAsync()>0)
				{
					var userDetail = await _context.Bids.Include(x => x.User).Where(x => x.UserId == model.UserId).FirstOrDefaultAsync();
					_mailService.SendEmail("Your bid is success", "Your bid is :" + bid.BidAmount, bid.User.UserName);
					_response.isSuccess = true;
					_response.Result = model;
					return _response;
				}
			}
			_response.isSuccess = false;
			_response.ErrorMessages.Add("Oops something went wrong");
			return _response;
		}

		public async Task<ApiResponse> GetBidById(int bidId)
		{
			var result = await _context.Bids.Include(x=>x.User).Where(x => x.BidId == bidId).FirstOrDefaultAsync();
			if(result == null)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("Bid is not found");
				return _response;
			}
			_response.isSuccess = true;
			_response.Result = result;
			return _response;
		}

		public async Task<ApiResponse> GetBidByVehicleId(int vehicleId)
		{
			var obj = await _context.Bids.Where(x => x.VehicleId == vehicleId).ToListAsync();
			if(obj!=null)
			{
				_response.isSuccess = true;
				_response.Result = obj;
				return _response;
			}
			_response.isSuccess = false;
			return _response;
		}

		public async Task<ApiResponse> UpdateBid(int bidId, UpdateBidDto model)
		{
			//Update eden kullanici en son verdigi teklifin uzerine cikmalidir.
			var isPaid = await CheckIsPaidAuction(model.UserId, model.VehicleId);
			if(!isPaid)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("You must pay the auction price before proceeding with this action.");
				return _response;
			}
			var result = await _context.Bids.FindAsync(bidId);
			if(result==null)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("Bid is not found");
				return _response;
			}
			if(result.BidAmount<model.BidAmount && result.UserId == model.UserId)
			{
				var objDto = _mapper.Map(model, result);
				objDto.BidDate = DateTime.Now;
				_response.isSuccess = true;
				_response.Result = objDto;
				await _context.SaveChangesAsync();
				return _response;
			}
			else if(result.BidAmount >= model.BidAmount)
			{
				_response.isSuccess = false;
				_response.ErrorMessages.Add("Your new bid must be higher than your previous bid. Your previous bid amount is " + result.BidAmount);
				return _response;
			}
			_response.isSuccess = false;
			_response.ErrorMessages.Add("An unexpected error occurred while updating the bid.");
			return _response;

		}
		private async Task<Vehicle>CheckIsActive(int vehicleId)
		{
			var obj = await _context.Vehicles.
				Where(x => x.VehicleId == vehicleId && x.IsActive==true && x.EndTime>= DateTime.Now).
				FirstOrDefaultAsync();
			if(obj!=null)
			{
				return obj;
			}
			return null;
		}
		private async Task<bool>CheckIsPaidAuction(string userId, int vehicleId)
		{
			var obj = await _context.PaymentHistories.
			Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
			if (obj != null)
			{
				return true;
			}
			return false;
		}
	}
}
