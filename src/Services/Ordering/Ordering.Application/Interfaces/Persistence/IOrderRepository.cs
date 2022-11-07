using Ordering.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.Application.Interface.Persistence
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
