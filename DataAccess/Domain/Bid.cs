﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccess.Domain
{
   public class Bid
    {
		public int BidId { get; set; }
		public decimal BidAmount { get; set; }
		public DateTime BidDate { get; set; }
		public string BidStatus { get; set; } = DataAccess.Enums.BidStatus.Pending.ToString();
		public string UserId { get; set; }
		[JsonIgnore]
		public ApplicationUser User { get; set; }
		public int VehicleId { get; set; }
		[JsonIgnore]
		public Vehicle Vehicle { get; set; }
	}
}
