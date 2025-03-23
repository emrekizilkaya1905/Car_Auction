using Auction_Business.Abstraction;
using Auction_Business.Concrete;
using Car_Auction.Extensions;
using Core.Model;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Auction_Business.Mapper.MappingProfile));
builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddPersistentLayer(builder.Configuration);
builder.Services.AddSwaggerCollection(builder.Configuration);
builder.Services.AddInfrastruceLayer(builder.Configuration);
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x=>x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin=>true).AllowCredentials());
app.UseAuthorization();
app.UseAuthentication();
app.UseStaticFiles();

app.MapControllers();

app.Run();
