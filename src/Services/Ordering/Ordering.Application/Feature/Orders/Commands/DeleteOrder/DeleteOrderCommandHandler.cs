using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.Exceptions;
using Ordering.Application.Interface.Persistence;
using Ordering.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Feature.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteOrderCommandHandler> _logger;

        public DeleteOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, ILogger<DeleteOrderCommandHandler> logger)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var orderToDelete = await _orderRepository.GetByIdAsync(request.Id);

            if (orderToDelete == null)
            {
                _logger.LogError($"Order with Id {request.Id} doesn't exist");
                throw new NotFoundException(nameof(Order), request.Id);
            }

            _logger.LogInformation($"Order {orderToDelete.Id} is successfully deleted.");
            await _orderRepository.DeleteAsync(orderToDelete);

            return Unit.Value;
        }
    }
}
