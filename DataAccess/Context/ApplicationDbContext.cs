﻿using DataAccess.Domain;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
   public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Bid> Bids { get; set; }
		public DbSet<Vehicle> Vehicles { get; set; }
		public DbSet<PaymentHistory> PaymentHistories { get; set; }
	}
}
