using Auction_Business.Abstraction;
using Auction_Business.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Car_Auction.Controllers;


[Route("api/[controller]")]
[ApiController]
public class VehicleController : ControllerBase
{
	private readonly IVehicleService _service;
	private readonly IWebHostEnvironment _enviroment;

	public VehicleController(IVehicleService service, IWebHostEnvironment environment)
	{
		_service = service;
		_enviroment = environment;
	}
	[HttpPost("CreateVehicle")]
	public async Task<IActionResult> AddVehicle([FromForm] CreateVehicleDto model)
	{
		if (ModelState.IsValid)
		{
			if (model.File == null || model.File.Length == null)
			{
				return BadRequest();
			}
			string uploadsFolder = Path.Combine(_enviroment.ContentRootPath, "Images");
			string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.File.FileName)}";
			string filePath = Path.Combine(uploadsFolder, fileName);

			model.Image = fileName;
			var result = await _service.CreateVehicle(model);
			if (result.isSuccess)
			{
				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					await model.File.CopyToAsync(fileStream);
				}
				return Ok(result);
			}
		}
		return BadRequest();
	}
	[HttpGet("GetVehicles")]
	public async Task<IActionResult> GetVehicles()
	{
		var vehicles = await _service.GetVehicles();
		return Ok(vehicles);
	}
	[HttpPut("UpdateVehicle")]
	public async Task<IActionResult> UpdateVehicle(int vehicleId, [FromForm] UpdateVehicleDto model)
	{
		if (ModelState.IsValid)
		{
			var result = await _service.UpdateVehicleResponse(vehicleId, model);
			if (result.isSuccess)
			{
				return Ok(result);
			}

		}
		return BadRequest();
	}
	[Authorize(Roles = "Administrator")]
	[HttpDelete("Remove/Vehicle/{vehicleId}")]
	
	public async Task<IActionResult> DeleteVehicle([FromRoute] int vehicleId)
	{
		var result = await _service.DeleteVehicle(vehicleId);
		if (result.isSuccess)
		{
			return Ok(result);
		}
		return BadRequest();
	}
	[HttpGet("{vehicleId}")]
	public async Task<IActionResult> GetVehicleById([FromRoute] int vehicleId)
	{
		var result = await _service.GetVehicleById(vehicleId);
		if (result.isSuccess)
		{
			return Ok(result);
		}
		return BadRequest();
	}
	[HttpPut("{vehicleId}")]
	public async Task<IActionResult> ChangeVehicleStatus([FromRoute] int vehicleId)
	{
		var result = await _service.ChangeVehicleStatus(vehicleId);
		if (result.isSuccess)
		{
			return Ok(result);
		}
		return BadRequest();
	}
}


