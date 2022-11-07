using AutoMapper;
using Ordering.Application.Feature.Orders.Commands.CheckoutOrder;
using Ordering.Application.Feature.Orders.Commands.UpdateOrder;
using Ordering.Application.Feature.Orders.Queries.GetOrdersList;
using Ordering.Domain.Models;

namespace Ordering.Application.Mapping
{
    class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Order, OrdersVM>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
