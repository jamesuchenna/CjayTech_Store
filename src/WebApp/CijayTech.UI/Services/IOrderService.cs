using AspnetRunBasics.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CjayTech.UI.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
