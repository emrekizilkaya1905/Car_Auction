using Auction_Business.Abstraction;
using Auction_Business.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Auction.Controllers;


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
		private readonly IUserService _service;
		public UserController(IUserService service)
		{
			_service = service;
		}
		[HttpPost("Register")]
		public async Task<IActionResult> CreateUser([FromBody] RegisterRequestDto model)
		{
			var response =await _service.Register(model);
			if(response.isSuccess)
			{
				return Ok(response);
			}
			return BadRequest(response);
		}

		[HttpPost("Login")]
		public async Task<IActionResult> LoginUser ([FromBody] LoginRequestDto model)
		{
			var response = await _service.Login(model);
			if(response.isSuccess)
			{
				return Ok(response);
			}
			return BadRequest(response);
		}
	}

