using Auction_Business.Abstraction;
using Auction_Business.Dtos;
using Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Auction.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentHistoryController : ControllerBase
	{
		private readonly IPaymentHistoryService _paymentHistoryService;
		public PaymentHistoryController(IPaymentHistoryService paymentHistoryService)
		{
			_paymentHistoryService = paymentHistoryService;
		}
		[HttpPost("AddHistory")]
		public async Task<IActionResult> CreatePaymentHistory(CreatePaymentHistoryDto model)
		{
			if(ModelState.IsValid)
			{
				var response = await _paymentHistoryService.CreatePaymentHistory(model);
				if(!response.isSuccess)
				{
					return BadRequest(response);
				}
				return Ok(response);

			}
			return BadRequest();
		}
		[HttpPost("CheckStatus")]
		public async Task<IActionResult> CheckStatusAuction(CheckStatusModel model)
		{
			var response= await _paymentHistoryService.CheckIsStatusForAuction(model.UserId, model.VehicleId);
			
			return Ok(response);
		}
	}
}
