using Auction_Business.Dtos;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Business.Abstraction
{
    public interface IPaymentHistoryService
    {
        Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDto model);
        Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId);
    }
}
