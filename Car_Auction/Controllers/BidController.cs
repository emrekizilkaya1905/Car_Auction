﻿using Auction_Business.Abstraction;
using Auction_Business.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
		private readonly IBidService _bidService;
		public BidController(IBidService bidService)
		{
			_bidService = bidService;
		}
		[HttpPost("Create")]
		public async Task<IActionResult>CreateBid(CreateBidDto model)
		{
			if(ModelState.IsValid)
			{
				var response = await _bidService.CreateBid(model);
				if(!response.isSuccess)
				{
					return BadRequest(response);
				}
				return Ok(response);
			}
			return BadRequest();
		}
		[HttpGet("{bidId:int}")]
		public async Task<IActionResult> GetBidById(int bidId)
		{
			
				var response = await _bidService.GetBidById(bidId);
				if (!response.isSuccess)
				{
					return BadRequest(response);
				}
				return Ok(response);
			
		}
		[HttpPut("{bidId:int}")]
		public async Task<IActionResult> UpdateBid(int bidId, UpdateBidDto model)
		{
			if (ModelState.IsValid)
			{
				var response = await _bidService.UpdateBid(bidId, model);
				if (!response.isSuccess)
				{
					return BadRequest(response);
				}
				return Ok(response);
			}
			return BadRequest();
		}
		[HttpPost]
		public async Task<IActionResult> AutoBid(CreateBidDto model)
		{
			if (ModelState.IsValid)
			{
				var response = await _bidService.AutomaticallyCreateBid(model);
				if (!response.isSuccess)
				{
					return BadRequest(response);
				}
				return Ok(response);
			}
			return BadRequest();
		}
		[HttpGet("GetBidsByVehicle/{bidId:int}")]
		public async Task<IActionResult> GetBidByVehicle(int bidId)
		{

			var response = await _bidService.GetBidByVehicleId(bidId);
			if (!response.isSuccess)
			{
				return BadRequest(response);
			}
			return Ok(response);

		}
	}
}
