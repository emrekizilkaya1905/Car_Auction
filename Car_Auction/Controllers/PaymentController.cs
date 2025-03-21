﻿using Auction_Business.Dtos;
using Core.Model;
using DataAccess.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System.Configuration;

namespace Car_Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ApiResponse _response;
        private readonly IConfiguration _configuration;
		private readonly ApplicationDbContext _context;

		public PaymentController(ApiResponse response, IConfiguration configuration, ApplicationDbContext context)
		{
			_response = response;
			_configuration = configuration;
			_context = context;
		}
		[HttpPost("Pay")]
		public async Task<ActionResult<ApiResponse>> MakePayment(string userId, int vehicleId)
		{
			StripeConfiguration.ApiKey = _configuration.GetValue<string>("StripeSettings:SecretKey");
			var amountToBePaid = await _context.Vehicles.FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
			var options = new PaymentIntentCreateOptions
			{
				Amount = (int)(amountToBePaid.AuctionPrice * 100),
				Currency = "usd",
				PaymentMethodTypes = new List<string> { "card" }
			};
			var service = new PaymentIntentService();
			var response = service.Create(options);
			CreatePaymentHistoryDto model = new ()
			{
				ClientSecret= response.ClientSecret,
				StripePaymentId=response.Id,
				UserId=userId,
				VehicleId=vehicleId
			};
			_response.Result = model;
			_response.StatusCode = System.Net.HttpStatusCode.OK;
			return Ok(_response);
		}
	}
}
