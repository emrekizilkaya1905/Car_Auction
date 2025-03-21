using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Business.Dtos
{
   public class CreatePaymentHistoryDto
    {

		public string ClientSecret { get; set; }
		public string StripePaymentId { get; set; }
		public string UserId { get; set; }
		public int VehicleId { get; set; }
	}
}
