﻿using DataAccess.Domain;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Business.Dtos
{
    public class CreateBidDto
    {
		public decimal BidAmount { get; set; }
	
		public string UserId { get; set; }
	
		public int VehicleId { get; set; }

	}
}
