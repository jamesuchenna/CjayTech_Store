using Ordering.Domain.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Interfaces.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
